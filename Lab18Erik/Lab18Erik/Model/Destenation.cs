using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18Erik.Model
{
    public class Destenation
    {   
        [Key]
        public int DestenationID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Supply> Items { get; set; }

    }
}
