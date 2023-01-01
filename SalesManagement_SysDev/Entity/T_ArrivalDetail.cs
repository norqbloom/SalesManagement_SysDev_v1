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
    class T_ArrivalDetail
    {
        [Key]
        [DisplayName("入荷詳細ID")]
        public int ArDetailID { get; set; }     //入荷詳細ID　
        [DisplayName("入荷ID")]
        public int ArID { get; set; }           //入荷ID　
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID　
        [DisplayName("数量")]
        public int ArQuantity { get; set; }	    //数量

    }
}
