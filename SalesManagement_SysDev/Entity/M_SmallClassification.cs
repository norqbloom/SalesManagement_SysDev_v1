using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SalesManagement_SysDev
{
    class M_SmallClassification
    {
        [Key]
        [DisplayName("小分類ID")]
        public int ScID { get; set; }           //小分類ID	

        [DisplayName("大分類ID")]
        public int McID { get; set; }           //大分類ID

        [MaxLength(50)]
        [Required]
        [DisplayName("小分類名")]
        public String ScName { get; set; }      //小分類名	

        [DisplayName("小分類管理フラグ")]
        public int ScFlag { get; set; }         //小分類管理フラグ

        [DisplayName("非表示理由")]
        public String ScHidden { get; set; }	//非表示理由		

    }
}
