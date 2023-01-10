using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SalesManagement_SysDev
{
    class T_Hattyu
    {
        [Key]
        [DisplayName("発注ID")]
        public int HaID { get; set; }                   //発注ID	

        [DisplayName("メーカID")]
        public int MaID { get; set; }                   //メーカID	

        [DisplayName("発注社員ID")]
        public int EmID { get; set; }                   //発注社員ID

        [DisplayName("発注年月日")]
        public DateTime HaDate { get; set; }            //発注年月日	
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        [DisplayName("入庫済フラグ")]
        public int? WaWarehouseFlag { get; set; }   //入庫済フラグ（倉庫）

        [DisplayName("発注管理フラグ")]
        public int HaFlag { get; set; }             //発注管理フラグ

        [DisplayName("非表示理由")]
        public String HaHidden { get; set; }            //非表示理由	
  	
    }
}
