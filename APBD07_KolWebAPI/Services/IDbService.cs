using APBD07_KolWebAPI.DTOs;

namespace APBD07_KolWebAPI.Services;

public interface IDbService
{
    Task<PatientDto> GetPatientAndVisits(string? lastName);
}