using System.ComponentModel.DataAnnotations;

namespace TvcDay06Annotation.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public long id { get; set; }

        [Required]
        [StringLength(10, MinimumLength =5,ErrorMessage ="User name: tối thiếu 5 ký tự, tối đa 10 ký tự")]

        public string Name { get; set; }

        [Required(ErrorMessage ="Nhập mật khẩu")]
        [StringLength(100, MinimumLength=6, ErrorMessage ="Mật khẩu tối thiểu 6 ký tự")]
        public string Password { get; set; }

        [Required (ErrorMessage ="Chưa nhập lại mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu không giống nhau")]
        public string ReenterPassword { get; set; }

        [Required (ErrorMessage ="Nhập tuổi...")]
        [Range(18,60,ErrorMessage ="Tuổi trong khoảng 18-60")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Bạn chưa nhập email")]
        [RegularExpression(@"[A-Za-z0-9.]+[A-Za-z0-9]+@[A-Za-z0-9]+[A-Za-z0-9.]*\.[A-Za-z]{2,4}$",ErrorMessage ="Bạn chưa nhập đúng định dạng")]
        public string Email { get; set; }
    }
}
