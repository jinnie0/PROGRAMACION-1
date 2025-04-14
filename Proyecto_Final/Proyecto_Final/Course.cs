public class Course
{
    public string CourseName { get; set; }
    public string Teacher { get; set; }

    public Course(string courseName, string teacher)
    {
        CourseName = courseName;
        Teacher = teacher;
    }

    public override string ToString()
    {
        return CourseName;
    }
}
