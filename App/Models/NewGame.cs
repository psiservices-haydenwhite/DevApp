using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class NewGame
    {
        public int DevId { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ESRBRating { get; set; }
    }
}
