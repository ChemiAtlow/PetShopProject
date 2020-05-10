using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Models
{
    /// <summary>
    /// Comment regarding an animal in the pet shop.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Id of comment.
        /// </summary>
        public int CommentId { get; set; }
        /// <summary>
        /// The animal the current comment is for.
        /// </summary>
        public virtual Animal Animal { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [Required(ErrorMessage = "עליך לכתוב תגובה!")]
        [Display(Name = "כתוב תגובתך")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "תגובה תהיה באורך 3 תווים עד 300")]
        public string CommentText { get; set; }
    }
}
