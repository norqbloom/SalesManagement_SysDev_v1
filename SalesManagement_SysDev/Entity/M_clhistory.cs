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
    class M_clhistory
    {
        [Key]
        public int hisID { get; set; }

        [Required]
        public string ClID { get; set; }

        [Required]
        public DateTime RegisteredDate { get; set; }

        [Required]
        public DateTime UpDateTime { get; set; }

        [Required]
        public string LastupdatedUser { get; set; }
    }
}
