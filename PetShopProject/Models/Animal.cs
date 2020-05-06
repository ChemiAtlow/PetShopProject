using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopProject.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "לא כתבת את שם החיה!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "שם החיה צריך להיות בין 3 ל30 תווים!")]
        [Display(Name = "שם החיה")]
        public string Name { get; set; }
        [Required(ErrorMessage = "לא כתבת את גיל החיה!")]
        [Range(0.1, 80, ErrorMessage = "גיל צריך להיות גדול מ0 וקטן מ80.")]
        [Display(Name = "גיל החיה")]
        public double Age { get; set; }
        [Display(Name = "תמונה מייצגת")]
        public string PictureName { get; set; }
        [Required(ErrorMessage = "לא כתבת תיאור לחיה!")]
        [MinLength(5, ErrorMessage = "התיאור חייב להכיל לכל הפחות 5 תווים!")]
        [Display(Name = "תיאור בעל החי")]
        public string Description { get; set; }
        [Display(Name = "קטגוריה")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        #region CategoryId for form
        [NotMapped]
        [ValidCategory]
        [Required(AllowEmptyStrings = false, ErrorMessage = "לא בחרת קטגוריה!")]
        [Display(Name = "קטגוריה")]
        public int? FormCategoryId { get; set; }
        #endregion


        #region File UPload
        [NotMapped]
        [RequiredIfHasId(nameof(AnimalId), ErrorMessage = "לא בחרת תמונה!")]
        [MaxFileSize(4 * 1024 * 1024)]
        [AllowedExtensions(".jpg", ".jpeg", ".png", ".gif")]
        [DataType(DataType.Upload)]
        [Display(Name = "תמונה מייצגת")]
        public IFormFile FormFile { get; set; }
        #endregion

    }

}
