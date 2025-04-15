using System;

namespace SistemaNotasEscolares.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Name}";
        }
    }
}