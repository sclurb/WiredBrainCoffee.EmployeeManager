using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string? Lastname { get; set; }
        public bool IsDeveloper { get; set; }
        [Required]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        [Timestamp]
        public byte[]? TimeStamp { get; set; }
    }
}
