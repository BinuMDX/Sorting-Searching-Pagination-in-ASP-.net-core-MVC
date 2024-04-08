using System.ComponentModel.DataAnnotations;

namespace Pagination.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public string StartDateString { get; set; }
        public int Salary { get; set; }
    }
}
