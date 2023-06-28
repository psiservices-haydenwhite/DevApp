using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Founded { get; set; }
        public string Headquarters { get; set; }
    }
}
