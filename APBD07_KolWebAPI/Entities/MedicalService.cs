using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Entities;

[Table("Medical_Services")]
[PrimaryKey(nameof(ServiceId))]
public class MedicalService
{
    [Key]
    private int ServiceId { get; set; }
    
    [MaxLength(100)]
    private string Name { get; set; }
    [MaxLength(100)]
    private string Description { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    private decimal Price { get; set; }

    private int DurationMinutes { get; set; }

    [Column(TypeName = "datetime")]
    private DateTime PerformedAt { get; set; }
    
    //nav
    public ICollection<AppointmentService> AppointmentServices { get; set; } = [];
}