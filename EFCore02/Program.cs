using EFCore02.Contexts;
using EFCore02.Entites;
using System.Linq;
namespace EFCore02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITI02Dbcontext dbcontext = new ITI02Dbcontext();
            var department = new Department { Name = "Computer Science", HiringDate = DateTime.Now };
            dbcontext.Department.Add(department);
            dbcontext.SaveChanges();

           
            var students = dbcontext.Student.ToList();

            
            var student = dbcontext.Student.First();
            student.FName = "Ahmed";
            dbcontext.SaveChanges();

           
            var instructor = dbcontext.Instructor.First();
            dbcontext.Instructor.Remove(instructor);
            dbcontext.SaveChanges();

        }
    }
}
