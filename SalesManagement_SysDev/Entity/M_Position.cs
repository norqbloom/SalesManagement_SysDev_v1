using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SalesManagement_SysDev
{
    class M_Position
    { 

        [Key]
        [DisplayName("役職ID")]
        public int PoID { get; set; }           //役職ID

        [MaxLength(50)]
        [Required]
        [DisplayName("役職名")]
        public String PoName { get; set; }      //役職名	

        [DisplayName("役職管理フラグ")]
        public int PoFlag { get; set; }         //役職管理フラグ

        [DisplayName("非表示理由")]
        public String PoHidden { get; set; }    //非表示理由		
 
    }
}
