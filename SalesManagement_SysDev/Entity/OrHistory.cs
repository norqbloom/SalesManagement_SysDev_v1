﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev.Entity
{
    class OrHistory
    {
        [Key]
        public int orNo { get; set; }

        public string OrID { get; set; }
        public string SoID { get; set; }
        public string EmID { get; set; }
        public string ClID { get; set; }

        public string RegisteredDate { get; set; }
        public string regUserID { get; set; }
        public string regUserName { get; set; }
        public string UpDateTime { get; set; }

        public string LastupdatedUserID { get; set; }
        public string LastupdatedUserName { get; set; }

    }
}
