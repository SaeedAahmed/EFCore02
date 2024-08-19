using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entites
{
    internal class Department
    {
        public int Dept_Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
