using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaNotasEscolares.Model
{
    public class Database
    {
        public List<Student> Students { get; private set; }
        public List<Course> Courses { get; private set; }
        public List<Grade> Grades { get; private set; }

        public Database()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

        public List<Grade> GetGrades()
        {
            return Grades;
        }

        public void SaveToFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Guardar estudiantes
                    writer.WriteLine($"STUDENTS:{Students.Count}");
                    foreach (var student in Students)
                    {
                        writer.WriteLine($"{student.Id},{student.Name}");
                    }

                    // Guardar cursos
                    writer.WriteLine($"COURSES:{Courses.Count}");
                    foreach (var course in Courses)
                    {
                        writer.WriteLine($"{course.Id},{course.Name}");
                    }

                    // Guardar calificaciones
                    writer.WriteLine($"GRADES:{Grades.Count}");
                    foreach (var grade in Grades)
                    {
                        writer.WriteLine($"{grade.Student.Id},{grade.Course.Id},{grade.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar datos: " + ex.Message);
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                Students.Clear();
                Courses.Clear();
                Grades.Clear();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    // Leer estudiantes
                    string line = reader.ReadLine();
                    int studentCount = int.Parse(line.Split(':')[1]);

                    for (int i = 0; i < studentCount; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(',');
                        Students.Add(new Student(int.Parse(parts[0]), parts[1]));
                    }

                    // Leer cursos
                    line = reader.ReadLine();
                    int courseCount = int.Parse(line.Split(':')[1]);

                    for (int i = 0; i < courseCount; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(',');
                        Courses.Add(new Course(int.Parse(parts[0]), parts[1]));
                    }

                    // Leer calificaciones
                    line = reader.ReadLine();
                    int gradeCount = int.Parse(line.Split(':')[1]);

                    for (int i = 0; i < gradeCount; i++)
                    {
                        line = reader.ReadLine();
                        string[] parts = line.Split(',');

                        int studentId = int.Parse(parts[0]);
                        int courseId = int.Parse(parts[1]);
                        float value = float.Parse(parts[2]);

                        Student student = Students.FirstOrDefault(s => s.Id == studentId);
                        Course course = Courses.FirstOrDefault(c => c.Id == courseId);

                        if (student != null && course != null)
                        {
                            Grades.Add(new Grade(student, course, value));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar datos: " + ex.Message);
            }
        }
    }
}