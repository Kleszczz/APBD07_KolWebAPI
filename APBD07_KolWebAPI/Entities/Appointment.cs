using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Entities;

[Table("Appointments")]
[PrimaryKey(nameof(AppointmentId))]
public class Appointment
{
    [Key]
    private int AppointmentId{ get; set; }
    
    private int PatientId { get; set; }
    private int DoctorId { get; set; }
    
    [Column(TypeName = "datetime")]
    private DateTime AppointmentDate { get; set; }
    
    [MaxLength(50)]
    private string Status { get; set; }
    
    [ForeignKey(nameof(PatientId))]
    public Patient Patient { get; set; }
    
    [ForeignKey(nameof(DoctorId))]
    public Doctor Doctor { get; set; }
    
    public ICollection<AppointmentService> AppointmentServices { get; set; } = [];
}