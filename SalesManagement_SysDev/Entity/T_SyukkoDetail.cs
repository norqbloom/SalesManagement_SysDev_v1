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
    class T_SyukkoDetail
    {
        [Key]
        [DisplayName("出庫詳細ID")]
        public int SyDetailID { get; set; }     //出庫詳細ID　
        [DisplayName("出庫ID")]
        public int SyID { get; set; }           //出庫ID　
        [DisplayName("商品ID")]
        public int PrID { get; set; }           //商品ID　
        [DisplayName("数量")]
        public int SyQuantity { get; set; }	    //数量

    }
}
