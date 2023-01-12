using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SalesManagement_SysDev
{
    class M_SalesOffice
    {
        [Key]
        [DisplayName("営業所ID")]
        public int SoID { get; set; }           //営業所ID

        [MaxLength(50)]
        [Required]
        [DisplayName("営業所名")]
        public String SoName { get; set; }      //営業所名	

        [MaxLength(50)]
        [Required]
        [DisplayName("住所")]
        public String SoAddress { get; set; }   //住所

        [MaxLength(13)]
        [Required]
        [DisplayName("電話番号")]
        public String SoPhone { get; set; }     //電話番号

        [MaxLength(7)]
        [Required]
        [DisplayName("郵便番号")]
        public String SoPostal { get; set; }    //郵便番号	

        [MaxLength(13)]
        [Required]
        [DisplayName("FAX")]
        public String SoFAX { get; set; }       //FAX	

        [DisplayName("営業所管理フラグ")]
        public int SoFlag { get; set; }         //営業所管理フラグ	 

        [DisplayName("非表示理由")]
        public String SoHidden { get; set; }	//非表示理由		
    }
}
