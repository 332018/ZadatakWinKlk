using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetDataAccessLayer.Models
{
    public class Veterinar
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialy { get; set; }
        public int Years { get; set; }
    }
}
