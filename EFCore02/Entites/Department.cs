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
        public int Ins_id { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
