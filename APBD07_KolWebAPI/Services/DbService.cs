using APBD07_KolWebAPI.Data;
using APBD07_KolWebAPI.DTOs;

namespace APBD07_KolWebAPI.Services;

public class DbService: IDbService
{
    private readonly AppDbContext _context;

    public DbService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<PatientDto> GetPatientAndVisits(string? lastName)
    {
        var patients = await _context.Patients
            .Select(patient => new PatientDto
            {
                
            })
    }
}