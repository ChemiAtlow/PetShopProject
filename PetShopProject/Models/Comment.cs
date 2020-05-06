using PetShopProject.Models.AspNetCoreCourseProject.Models;
using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public virtual Animal Animal { get; set; }
        [Required(ErrorMessage = "עליך לכתוב תגובה!")]
        [Display(Name = "כתוב תגובתך")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "תגובה תהיה באורך 3 תווים עד 300")]
        public string CommentText { get; set; }
    }
}
