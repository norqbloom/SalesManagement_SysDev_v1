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
    class M_Product
    {
        [Key]
        [DisplayName("商品ID")]
        public int PrID { get; set; }               //商品ID		

        [DisplayName("メーカID")]
        public int MaID { get; set; }               //メーカID	

        [MaxLength(50)]
        [Required]
        [DisplayName("商品名")]
        public String PrName { get; set; }           //商品名
        
        [DisplayName("価格")]
        public int Price { get; set; }              //価格	

        [MaxLength(13)]
        public String PrJCode { get; set; }         //JANコード	

        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }      //安全在庫数	

        [DisplayName("小分類ID")]
        public int ScID { get; set; }               //小分類ID	
       
        [MaxLength(20)]
        [Required]
        [DisplayName("型番")]
        public String PrModelNumber { get; set; }      //型番
        
        [MaxLength(20)]
        [Required]
        [DisplayName("色")]
        public String PrColor { get; set; }         //色		

        [DisplayName("発売日")]
        public String PrReleaseDate { get; set; } //発売日		

        [DisplayName("商品管理フラグ")]
        public int PrFlag { get; set; }             //商品管理フラグ

        [DisplayName("非表示理由")]
        public String PrHidden { get; set; }	    //非表示理由		

    }
}
