using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalesManagement_SysDev
{
    class M_Prohistory
    {
        [Key]
        public int hisNo { get; set; }

        public string PrID { get; set; }

        public string RegisteredDate { get; set; }
        public string regUserID { get; set; }
        public string regUserName { get; set; }
        public string UpDateTime { get; set; }

        public string LastupdatedUserID { get; set; }
        public string LastupdatedUserName { get; set; }
    }
}
