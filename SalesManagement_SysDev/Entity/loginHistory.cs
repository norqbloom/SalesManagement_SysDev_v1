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
        public string position { get; set; }

        public string EmID { get; set; }
        public string EmName { get; set; }
        public string loginTime { get; set; }
        public string logoutTime { get; set; }

    }
}
