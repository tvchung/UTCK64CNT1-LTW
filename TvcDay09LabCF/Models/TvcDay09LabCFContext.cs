using Microsoft.EntityFrameworkCore;

namespace TvcDay09LabCF.Models
{
    public class TvcDay09LabCFContext:DbContext
    {
        public TvcDay09LabCFContext(DbContextOptions<TvcDay09LabCFContext> options)
                :base(options) { }
        public DbSet<TvcLoai_San_Pham> tvcLoai_San_Phams { get; set; }
        public DbSet<TvcSan_Pham> tvcSan_Phams { get; set; }
    }
}
