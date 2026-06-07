using APBD07_KolWebAPI.Data;
using APBD07_KolWebAPI.Entities;
using APBD07_KolWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD07_KolWebAPI.Controllers;

[Route("api/{controller}")]
[ApiController]
public class PatientController : ControllerBase
{
    private readonly IDbService _dbService;

    public PatientController(IDbService dbService)
    {
        _dbService = dbService;
    }

    
    //api/patients
    //GET /api/patients
    //GET /api/patients?lastName=Kow
    //GET /api/patients?lastName=Kowalska
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string? lastName)
    {
        try
        {
            var order = await _dbService.GetPatientAndVisits(lastName);
            return Ok(order);
        }
        catch (Exception ex)
        {
            return NotFound();
        }
    }
}