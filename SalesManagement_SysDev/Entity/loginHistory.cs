using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagement_SysDev
{
    class loginHistory
    {
        [Key]
        public int No { get; set; }
        [Required]
        public string position { get; set; }

        [Required]
        public string EmID { get; set; }
        [Required]
        public string EmName { get; set; }
        [Required]
        public DateTime loginTime { get; set; }
    }
}
