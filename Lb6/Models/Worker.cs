using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6.Models
{
    public class Worker
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Salary { get; set; }

        public virtual Department Department { get; set; }
    }
}
