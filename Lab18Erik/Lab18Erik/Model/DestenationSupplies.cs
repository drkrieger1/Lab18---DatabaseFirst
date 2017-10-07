using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18Erik.Model
{
    public class DestenationSupplies
    {   [Key]
        public int DestenationID { get; set; }
        [Key]
        public int SupplyID { get; set; }

        public Destenation Destenation { get; set; }
        public Supply Supply { get; set; }
    }
}
