using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entites
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string FName { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(22, 60)]
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
