namespace APBD07_KolWebAPI.DTOs;

public class GetPatientWithVisitsAndServices
{ 
    private string FirstName { get; set; }
    private string LastName { get; set; }
    DateTime DateOfBirth { get; set; }
    private string Phone { get; set; }
    private AppointmentDto appointments  { get; set; }
}

public partial class AppointmentDto
{
    private int AppointmentId{ get; set; }
    private DoctorDto DoctorDto{ get; set; }
    
    private DateTime AppointmentDate { get; set; }
    private string Status { get; set; }
    
    appointmentServiceDto appointmentServiceDto { get; set; }
}


public partial class DoctorDto
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string Specialization { get; set; }
    private string Phone { get; set; }
}

public partial class appointmentServiceDto
{
    private int Quantity { get; set; }
    
    private DateTime PerformedAt { get; set; }
    
    private MedicalServiceDto MedicalServiceDto { get; set; }
}


public partial class MedicalServiceDto
{
    private int ServiceId { get; set; }
    private string Name { get; set; }
    private string Description { get; set; }
    private decimal Price { get; set; }
    private int DurationMinutes { get; set; }

}