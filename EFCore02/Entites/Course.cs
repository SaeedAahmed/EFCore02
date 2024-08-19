using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Topic")]
        public int Top_Id { get; set; }
        public Topic Topic { get; set; }
    }
}
