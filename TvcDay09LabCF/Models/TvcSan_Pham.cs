using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvcDay09LabCF.Models
{
    [Table("TvcSan_Pham")]
    public class TvcSan_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long tvcId { get; set; }
        public string tvcMaSanPham { get; set; }
        public string tvcTenSanPham { get; set; }
        public string tvcHinhAnh { get;set; }
        public int tvcSoLuong { get; set; }
        public decimal tvcDonGia { get; set; }  
        public long tvcMaLoai { get; set; }

        public bool tvcTrangThai { get; set; }

        public TvcLoai_San_Pham tvcLoai_San_Pham { get; set; }
    }
}
