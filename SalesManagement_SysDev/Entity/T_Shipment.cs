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
    class T_Shipment
    {
        [Key]
        [DisplayName("出荷ID")]
        public int ShID { get; set; }               //出荷ID	
        [DisplayName("顧客ID")]
        public int ClID { get; set; }               //顧客ID	
        [DisplayName("社員ID")]
        public int EmID { get; set; }               //社員ID	
        [DisplayName("営業所ID")]
        public int SoID { get; set; }               //営業所ID		
        [DisplayName("受注ID")]
        public int OrID { get; set; }               //受注ID		
        [DisplayName("出荷状態フラグ")]
        public int? ShStateFlag { get; set; }	//出荷状態フラグ
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("出荷完了年月日")]
        public DateTime? ShFinishDate { get; set; }  //出荷完了年月日　
        [DisplayName("出荷管理フラグ")]
        public int ShFlag { get; set; }	//出荷管理フラグ　
        [DisplayName("非表示理由")]
        public String ShHidden { get; set; }	    //非表示理由		

    }
}
