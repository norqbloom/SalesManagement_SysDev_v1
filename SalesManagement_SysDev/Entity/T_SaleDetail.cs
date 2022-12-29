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
    class T_SaleDetail
    {
        [Key]
        [DisplayName("売上明細ID")]
        public int SaDetailID { get; set; }         //売上明細ID　
        [DisplayName("売上ID")]
        public int SaID { get; set; }               //売上ID　
        [DisplayName("商品ID")]
        public int PrID { get; set; }               //商品ID　
        [DisplayName("個数")]
        public int SaQuantity { get; set; }         //個数　
        [DisplayName("合計金額")]
        public int SaPrTotalPrice { get; set; }	    //合計金額

    }
}
