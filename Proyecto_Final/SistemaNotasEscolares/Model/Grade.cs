using System;

namespace SistemaNotasEscolares.Model
{
    public class Grade
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public float Value { get; set; }

        public Grade(Student student, Course course, float value)
        {
            Student = student;
            Course = course;
            Value = value;
        }

        public override string ToString()
        {
            return $"Estudiante: {Student.Name}, Curso: {Course.Name}, Calificación: {Value}";
        }
    }
}