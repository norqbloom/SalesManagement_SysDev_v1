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
        public int PrID { get; set; }               //商品ID		
        public int MaID { get; set; }               //メーカID	
        [MaxLength(50)]
        [Required]
        public String PrName { get; set; }           //商品名		
        public int Price { get; set; }              //価格	
        [MaxLength(13)]
        public String PrJCode { get; set; }         //JANコード		
        public int PrSafetyStock { get; set; }      //安全在庫数		
        public int ScID { get; set; }               //小分類ID	                                                
        [MaxLength(20)]
        [Required]
        public String PrModelNumber { get; set; }      //型番
        [MaxLength(20)]
        [Required]
        public String PrColor { get; set; }         //色		
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime PrReleaseDate { get; set; } //発売日		
        public int PrFlag { get; set; }             //商品管理フラグ
        public String PrHidden { get; set; }	    //非表示理由		
    }

    class M_ProductDsp
    {
        [DisplayName("商品ID")]
        public int PrID { get; set; }

        [DisplayName("メーカID")]
        public int MaID { get; set; }

        [DisplayName("商品名")]
        public string PrName { get; set; }

        [DisplayName("価格")]
        public int Price { get; set; }

        [DisplayName("JANコード")]
        public string PrJCode { get; set; }

        [DisplayName("安全在庫数")]
        public int PrSafetyStock { get; set; }

        [DisplayName("小分類ID")]
        public int ScID { get; set; }

        [DisplayName("型番")]
        public string PrModelNumber { get; set; }

        [DisplayName("色")]
        public string PrColor { get; set; }

        [DisplayName("発売日")]
        public DateTime PrReleaseDate { get; set; }

        [DisplayName("商品管理フラグ")]
        public int PrFlag { get; set; }

        [DisplayName("非表示理由")]
        public string PrHidden { get; set; }
    }
}
