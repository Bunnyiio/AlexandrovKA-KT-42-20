namespace _1laba.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
    }
}
