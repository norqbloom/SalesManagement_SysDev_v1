using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace SalesManagement_SysDev
{
    class T_HattyuDetail
    {
        [Key]
        [DisplayName("発注詳細ID")]
        public int HaDetailID { get; set; } //発注詳細ID

        [DisplayName("発注ID")]
        public int HaID { get; set; }       //発注ID

        [DisplayName("商品ID")]
        public int PrID { get; set; }       //商品ID

        [DisplayName("数量")]
        public int HaQuantity { get; set; }	//数量

    }
}
