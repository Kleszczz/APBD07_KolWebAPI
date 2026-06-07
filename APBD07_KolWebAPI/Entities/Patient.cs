using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Entities;

[Table("Patients")]
[PrimaryKey(nameof(PatientId))]
public class Patient
{
    [Key]
    private int PatientId { get; set; }
    [MaxLength(50)]
    private string FirstName { get; set; }
    [MaxLength(100)]
    private string LastName { get; set; }
    [Column(TypeName = "datetime")]
    DateTime DateOfBirth { get; set; }
    [MaxLength(9)]
    private string Phone { get; set; }

    //navigacje
    public ICollection<Appointment> Appointments { get; set; } = [];
}