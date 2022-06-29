using Inheritante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritante.Services
{
    public class StudentDataProvider : IEntityDataProvider<Student>
    {
        private List<Student> students = new List<Student>
        {
            new Student { Address ="ZH", AverageRate = 8, DateCreated = DateTime.Now, DateModified = DateTime.Now, Id = 1, Name = "Test 1", University="ZH"},
            new Student { Address ="BC", AverageRate = 7, DateCreated = DateTime.Now, DateModified = DateTime.Now, Id = 2, Name = "Test 2", University="BHG"},
            new Student { Address ="TU", AverageRate = 6, DateCreated = DateTime.Now, DateModified = DateTime.Now, Id = 3, Name = "Test 3", University="ZH"}
        };
        public async Task DeleteEntity(long entityId)
        {
            var student = students.FirstOrDefault(x => x.Id == entityId);

            if(student!=null)
            {
                students.Remove(student);
            }


        }

        public IList<Student> GetAllEntitiest()
        {
            return students.ToList();
        }

        public Student GetEntityById(long entityId)
        {
            var student = students.FirstOrDefault(x => x.Id == entityId);

            if(student!=null)
            {
                return student;
            }

            return null;
        }

        public async Task SaveEntity(Student entity)
        {
               students.Add(entity);
        }

        public async Task PrintStudents()
        {
            Console.WriteLine("Students:");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} Name: {student.Name}, AverageRate: {student.AverageRate}");
            }
        }
    }
}
