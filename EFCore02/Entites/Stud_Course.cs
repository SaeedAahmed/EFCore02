using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entites
{
    [PrimaryKey(nameof(stud_Id), nameof(Course_Id))]
    internal class Stud_Course
    {
        public int stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
    }
}
