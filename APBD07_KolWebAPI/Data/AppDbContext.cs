using APBD07_KolWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AppointmentService> AppointmentServices { get; set; }
    public DbSet<MedicalService> MedicalServices { get; set; }
    
    
}