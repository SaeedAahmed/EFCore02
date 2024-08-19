using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entites
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        [Range(1, 500, ErrorMessage = "HourRate must be between 1 and 200")]
        public double HourRate { get; set; }
        public double Bonus { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
