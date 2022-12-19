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
    class Hahistory
    {
        [Key]
        public int hisNo { get; set; }
        public string HaID { get; set; }
        public string MaID { get; set; }
        public string EmID { get; set; }
        public string RegisteredDate { get; set; }
        public string regUserID { get; set; }
        public string regUserName { get; set; }
        public string UpDateTime { get; set; }

        public string LastupdatedUserID { get; set; }
        public string LastupdatedUserName { get; set; }

    }
}
