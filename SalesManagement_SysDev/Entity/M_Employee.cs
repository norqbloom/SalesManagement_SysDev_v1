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
    class M_Employee
    {
        [Key]
        [DisplayName("社員ID")]
        public int EmID { get; set; }               //社員ID
        [MaxLength(50)]
        [Required]
        [DisplayName("社員名")]
        public String EmName { get; set; }          //社員名
        [DisplayName("営業所ID")]
        public int SoID { get; set; }               //営業所ID	
        [DisplayName("役職ID")]
        public int PoID { get; set; }               //役職ID
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("入社年月日")]
        public String EmHiredate { get; set; }    //入社年月日
        [MaxLength(100)]
        [Required]
        [DisplayName("パスワード")]
        public String EmPassword { get; set; }      //パスワード
        [MaxLength(13)]
        [Required]
        [DisplayName("電話番号")]
        public String EmPhone { get; set; }         //電話番号	
        //[MaxLength(13)]
        //[Required]
        // public String EmBarcode { get; set; }    //社員バーコード
        [DisplayName("社員管理フラグ")]
        public int EmFlag { get; set; }             //社員管理フラグ
        [DisplayName("非表示理由")]
        public String EmHidden { get; set; }	    //非表示理由		
    }
    class M_EmployeeDsp
    {
        [DisplayName("社員ID")]
        public int EmID { get; set; }

        [DisplayName("社員名")]
        public String EmName { get; set; }

        [DisplayName("営業所ID")]
        public int SoID { get; set; }

        [DisplayName("役職ID")]
        public int PoID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("入社年月日")]
        public String EmHiredate { get; set; }

        [DisplayName("パスワード")]
        public String EmPassword { get; set; }

        [DisplayName("電話番号")]
        public String EmPhone { get; set; }

        [DisplayName("社員管理フラグ")]
        public int EmFlag { get; set; }

        [DisplayName("非表示理由")]
        public String EmHidden { get; set; }

        
    }
}
