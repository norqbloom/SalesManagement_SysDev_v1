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
    class T_Chhistory
    {
        [Key]
        public int hisNo { get; set; }
        public string ChID { get; set; }
        public string RegisteredDate { get; set; }
        public string regUserID { get; set; }
        public string regUserName { get; set; }
        public string UpdateTime { get; set; }

        public string LastupdatedUserID { get; set; }
        public string LastupdatedUserName { get; set; }
    }
}