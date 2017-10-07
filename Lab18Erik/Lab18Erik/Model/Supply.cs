using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18Erik.Model
{
    public class Supply
    {   
        [Key]
        public int SupplyId { get; set; }
        public string Name { get; set; }
        public int ClimateID { get; set; }

    }
}
