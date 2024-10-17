using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema; // For IFormFile

namespace ST10038389_PROG6212___Part_2.Models
{
    public class Claim
    {
        public int Id { get; set; } // Unique identifier for the claim
        public string LecturerName { get; set; } // Name of the lecturer
        public string LecturerSurname { get; set; } // Surname of the lecturer
        public int HoursWorked { get; set; } // Number of hours worked
        public decimal HourlyRate { get; set; } // Hourly rate
        public string AdditionalNotes { get; set; } // Additional notes about the claim
        public string SupportingDocumentPath { get; set; } // Path to the uploaded supporting document
        public string Status { get; set; } // Status of the claim (e.g., Pending, Approved, Rejected)

        [NotMapped] // Exclude from database mapping
        public IFormFile SupportingDocument { get; set; } // Used for file upload
    }
}
