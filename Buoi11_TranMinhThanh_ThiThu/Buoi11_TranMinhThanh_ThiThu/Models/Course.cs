using System.ComponentModel.DataAnnotations;

namespace Buoi11_TranMinhThanh_ThiThu.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; } 
        public decimal Fee { get; set; }
    }
}
