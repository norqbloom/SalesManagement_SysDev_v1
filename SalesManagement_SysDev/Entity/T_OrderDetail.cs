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
    class T_OrderDetail
    {
        [Key]
        [DisplayName("受注詳細ID")]
        public int OrDetailID { get; set; }     //受注詳細ID
        [DisplayName("受注ID")]
        public int OrID { get; set; }           //受注ID
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID
        [DisplayName("数量")]
        public int OrQuantity { get; set; }	    //数量
        [DisplayName("合計金額")]
        public int OrTotalPrice { get; set; }	//合計金額

    }
}
