using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Entities;

[Table("Appointment_Services")]
[PrimaryKey(nameof(AppointmentId), nameof(ServiceId))]
public class AppointmentService
{
    private int AppointmentId { get; set; }
    private int ServiceId { get; set; }

    private int Quantity { get; set; }

    [Column(TypeName = "datetime")]
    private DateTime PerformedAt { get; set; }
    
    public Appointment Appointment { get; set; }
    public MedicalService MedicalService { get; set; }
    
}