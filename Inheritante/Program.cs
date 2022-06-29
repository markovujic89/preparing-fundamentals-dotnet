using Inheritante.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritante
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentDataProvider = new StudentDataProvider();

            studentDataProvider.DeleteEntity(1);

            studentDataProvider.SaveEntity(new Entities.Student
            {
                Address="VV",
                AverageRate = 9,
                Id = 5,
                Name = "Student 5",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                University = "BG"
            });
            studentDataProvider.PrintStudents();

            Console.ReadLine();
        }
    }
}
