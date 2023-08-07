using System.ComponentModel.DataAnnotations;

namespace BlogsWebApp.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string blogTitle { get; set; }

        [Required(ErrorMessage = "Please enter the content")]
        [StringLength(5000, MinimumLength = 500, ErrorMessage = "Blog should consist of at least of 500 characters")]
        [Display(Name = "Content")]
        public string blogContent { get; set; }

        [Display(Name = "Created Date")]
        public string createdDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");

        [Required(ErrorMessage = "Please enter the image link")]
        [Display(Name = "Image")]
        public string imageLink { get; set; }

        public string? userName { get; set; }
    }
}
