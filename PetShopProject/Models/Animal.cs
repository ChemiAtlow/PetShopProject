﻿using Microsoft.AspNetCore.Http;
using PetShopProject.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopProject.Models
{
    /// <summary>
    /// Animal in pet shop.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Id of animal.
        /// </summary>
        public int AnimalId { get; set; }

        /// <summary>
        /// Name of the animal.
        /// </summary>
        [Required(ErrorMessage = "לא כתבת את שם החיה!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "שם החיה צריך להיות בין 3 ל30 תווים!")]
        [Display(Name = "שם החיה")]
        public string Name { get; set; }

        /// <summary>
        /// Age of the animal.
        /// </summary>
        [Required(ErrorMessage = "לא כתבת את גיל החיה!")]
        [Range(0.1, 80, ErrorMessage = "גיל צריך להיות גדול מ0 וקטן מ80.")]
        [Display(Name = "גיל החיה")]
        public double Age { get; set; }

        /// <summary>
        /// Name of image representing the animal.
        /// </summary>
        [Display(Name = "תמונה מייצגת")]
        public string PictureName { get; set; }

        /// <summary>
        /// Description of the animal.
        /// </summary>
        [Required(ErrorMessage = "לא כתבת תיאור לחיה!")]
        [MinLength(5, ErrorMessage = "התיאור חייב להכיל לכל הפחות 5 תווים!")]
        [Display(Name = "תיאור בעל החי")]
        public string Description { get; set; }

        /// <summary>
        /// Category of the animal.
        /// </summary>
        [Display(Name = "קטגוריה")]
        public virtual Category Category { get; set; }

        /// <summary>
        /// The comments regarding this animal.
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }

        #region CategoryId for form
        /// <summary>
        /// A non-mapped property, for sending a categoryId.
        /// </summary>
        [NotMapped]
        [ValidCategory]
        [Required(AllowEmptyStrings = false, ErrorMessage = "לא בחרת קטגוריה!")]
        [Display(Name = "קטגוריה")]
        public int? FormCategoryId { get; set; }
        #endregion


        #region File UPload
        /// <summary>
        /// A non mapped property, to allow uploading an image.
        /// </summary>
        [NotMapped]
        [RequiredIfHasId(nameof(AnimalId))]
        [MaxFileSize(4 * 1024 * 1024)]
        [AllowedExtensions(".jpg", ".jpeg", ".png", ".gif")]
        [DataType(DataType.Upload)]
        [Display(Name = "תמונה מייצגת")]
        public IFormFile FormFile { get; set; }
        #endregion

    }

}
