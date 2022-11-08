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
        [Column("No", TypeName = "int", Order = 0)]
        [DisplayName("番号")]
        public string hisID { get; set; }

        [Required]
        [Column("ClID", TypeName = "int", Order = 0)]
        [DisplayName("顧客ID")]
        public string ClID { get; set; }

        [Required]
        [Column("RegisteredDate", TypeName = "DateTime", Order = 0)]
        [DisplayName("登録日時")]
        public DateTime RegisteredDate { get; set; }

        [Required]
        [Column("UpDateTime", TypeName = "UpDateTime", Order = 0)]
        [DisplayName("更新日時")]
        public DateTime UpDateTime { get; set; }

        [Required]
        [Column("LastupdatedUser", TypeName = "LastupdatedUser", Order = 0)]
        [DisplayName("最終更新者")]
        public string LastupdatedUser { get; set; }

    }
}
