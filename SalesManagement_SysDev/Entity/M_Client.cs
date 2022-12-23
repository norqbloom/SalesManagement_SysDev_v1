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
    class M_Client
    {
        [Key]
        [DisplayName("顧客ID")]
        public int ClID { get; set; }
        [DisplayName("営業所ID")]                  //顧客ID		
        public int SoID { get; set; }           //営業所ID
        [MaxLength(50)]
        [Required]
        [DisplayName("顧客名")]
        public String ClName { get; set; }      //顧客名
        [MaxLength(50)]
        [Required]
        [DisplayName("住所")]
        public String ClAddress { get; set; }   //住所	 
        [MaxLength(13)]
        [Required]
        [DisplayName("電話番号")]
        public String ClPhone { get; set; }     //電話番号	
        [MaxLength(7)]
        [Required]
        [DisplayName("郵便番号")]
        public String ClPostal { get; set; }       //郵便番号
        [MaxLength(13)]
        [Required]
        [DisplayName("FAX")]
        public String ClFAX { get; set; }       //FAX	
        [DisplayName("顧客管理フラグ")]
        public int ClFlag { get; set; }
        [DisplayName("非表示理由")]                                        //顧客管理フラグ	
        public String ClHidden { get; set; }	//非表示理由		

    }
}
