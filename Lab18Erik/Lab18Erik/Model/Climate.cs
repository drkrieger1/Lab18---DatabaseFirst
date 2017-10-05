using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18Erik.Model
{
    public class Climate
    {   
        [Key]
        public int ClimateID { get; set; }
        public string Name { get; set; }
        public int DestenationID { get; set; }
        public int SupplyItemID { get; set; }
    }
}
