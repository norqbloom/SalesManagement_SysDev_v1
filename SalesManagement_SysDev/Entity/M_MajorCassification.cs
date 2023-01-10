using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SalesManagement_SysDev
{
    class M_MajorCassification
    {
        [Key]
        [DisplayName("大分類ID")]
        public int McID { get; set; }           //大分類ID

        [MaxLength(50)]
        [Required]
        [DisplayName("大分類名")]
        public String McName { get; set; }      //大分類名

        [DisplayName("大分類管理フラグ")]    
        public int McFlag { get; set; }         //大分類管理フラグ

        [DisplayName("非表示理由")]
        public String McHidden { get; set; }	//非表示理由		

    }
}
