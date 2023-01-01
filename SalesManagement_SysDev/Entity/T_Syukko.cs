using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;



namespace SalesManagement_SysDev
{
    class T_Syukko
    {
        [Key]
        [DisplayName("出庫ID")]
        public int SyID { get; set; }               //出庫ID	
        [DisplayName("社員ID")]
        public int EmID { get; set; }               //社員ID	
        [DisplayName("顧客ID")]
        public int ClID { get; set; }               //顧客ID	
        [DisplayName("営業所ID")]
        public int SoID { get; set; }               //営業所ID	
        [DisplayName("受注ID")]
        public int OrID { get; set; }               //受注ID　
        [DisplayName("出庫年月日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? SyDate { get; set; }       //出庫年月日	
        [DisplayName("出庫状態フラグ")]
        public int? SyStateFlag { get; set; }    //出庫状態フラグ　
        [DisplayName("出庫管理フラグ")]
        public int SyFlag { get; set; }	//出庫管理フラグ　
        [DisplayName("非表示理由")]
        public String SyHidden { get; set; }	    //非表示理由	

    }
}
