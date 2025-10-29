using Microsoft.EntityFrameworkCore;

namespace TvcDay11JQueryAjax.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        // Bảng Students
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Đặt tên bảng
            modelBuilder.Entity<Student>().ToTable("TvcStudent");

            // Dữ liệu mẫu (seeding)
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Nguyễn Văn An", Age = 19 },
                new Student { Id = 2, Name = "Trần Thị Bình", Age = 20 },
                new Student { Id = 3, Name = "Lê Văn Cường", Age = 21 }
            );
        }
    }
}
