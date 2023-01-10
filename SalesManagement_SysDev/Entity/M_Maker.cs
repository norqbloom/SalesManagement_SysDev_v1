using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SalesManagement_SysDev
{
    class M_Maker
    {
        [Key]
        [DisplayName("メーカID")]
        public int MaID { get; set; }           //メーカID

        [MaxLength(50)]
        [Required]
        [DisplayName("メーカ名")]
        public String MaName { get; set; }      //メーカ名	
                                                //
        [MaxLength(50)]
        [Required]
        [DisplayName("住所")]
        public String MaAdress { get; set; }    //住所

        [MaxLength(13)]
        [Required]
        [DisplayName("電話番号")]
        public String MaPhone { get; set; }     //電話番号

        [MaxLength(7)]
        [Required]
        [DisplayName("郵便番号")]
        public String MaPostal { get; set; }    //郵便番号

        [MaxLength(13)]
        [Required]
        [DisplayName("FAX")]
        public String MaFAX { get; set; }       //FAX		

        [DisplayName("メーカ管理フラグ")]
        public int MaFlag { get; set; }         //メーカ管理フラグ

        [DisplayName("非表示理由")]
        public String MaHidden { get; set; }	//非表示理由		

    }
}
