using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SalesManagement_SysDev
{
    class T_Stock
    {
        [Key]
        [DisplayName("在庫ID")]
        public int StID { get; set; }           //在庫ID

        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID

        [DisplayName("在庫数")]
        public int StQuantity { get; set; }     //在庫数

        [DisplayName("在庫管理フラグ")]
        public int StFlag { get; set; }	        //在庫管理フラグ

    }
}
