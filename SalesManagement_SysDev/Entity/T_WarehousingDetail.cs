using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SalesManagement_SysDev
{
    class T_WarehousingDetail
    {
        [Key]
        [DisplayName("入庫詳細ID")]
        public int WaDetailID { get; set; }     //入庫詳細ID

        [DisplayName("入庫ID")]
        public int WaID { get; set; }           //入庫ID

        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID

        [DisplayName("数量")]
        public int WaQuantity { get; set; }     //数量

    }
}
