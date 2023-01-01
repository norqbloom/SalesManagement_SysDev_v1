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
    class T_ShipmentDetail
    {
        [Key]
        [DisplayName("出荷詳細ID")]
        public int ShDetailID { get; set; }     //出荷詳細ID　
        [DisplayName("出荷ID")]
        public int ShID { get; set; }           //出荷ID　
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID　
        [DisplayName("数量")]
        public int ShDquantity { get; set; }	//数量

    }
}
