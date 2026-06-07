using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD07_KolWebAPI.Entities;

[Table("Doctors")]
[PrimaryKey(nameof(DoctorId))]
public class Doctor
{
    [Key]
    private int DoctorId { get; set; }
    [MaxLength(50)]
    private string FirstName { get; set; }
    [MaxLength(100)]
    private string LastName { get; set; }
    
    [MaxLength(100)]
    private string Specialization { get; set; }
    
    [MaxLength(9)]
    private string Phone { get; set; }
    
    //nav
    public ICollection<Appointment> Appointments { get; set; } = [];

}