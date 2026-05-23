using StudentManagerwWebApp.Models.Student.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentManagerwWebApp.Models.Student
{
    public class StudentModel: IEntity
    {

        public StudentModel(int id, string name, string cpf, Gender gender, DateTime dayOfBirth)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Gender = gender;
            DayOfBirth = dayOfBirth;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Cpf { get; set; }
        public Gender Gender { get; set; }
        public DateTime DayOfBirth { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is StudentModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   Cpf == model.Cpf &&
                   Gender == model.Gender &&
                   DayOfBirth == model.DayOfBirth;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Cpf, Gender, DayOfBirth);
        }
    }
}
