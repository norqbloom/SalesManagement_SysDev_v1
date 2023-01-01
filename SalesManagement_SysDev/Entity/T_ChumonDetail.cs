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
    class T_ChumonDetail
    {
        [Key]
        [DisplayName("注文詳細ID")]
        public int ChDetailID { get; set; }     //注文詳細ID
        [DisplayName("注文ID")]
        public int ChID { get; set; }           //注文ID
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID
        [DisplayName("数量")]
        public int ChQuantity { get; set; }	    //数量

    }
}
