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
        public int hisNo { get; set; }

        public string ClID { get; set; }

        public DateTime RegisteredDate { get; set; }
        public string regUserID { get; set; }
        public string regUserName { get; set; }
        public DateTime UpDateTime { get; set; }

        public string LastupdatedUserID { get; set; }
        public string LastupdatedUserName { get; set; }
    }
}
