using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CollectionHub.Models
{
    public class Collection
    {
        public int Id { get; set; }
        
        [Display(Name = "Name of the collection")]
        [Required(ErrorMessage = "Name of the collection is not set")]
        [StringLength(50, MinimumLength = 3, 
            ErrorMessage = "Name of the collection cannot be shorter than 3 and less than 50 symbols")]
        public string Name { get; set; }
        
        [Display(Name = "Short description")]
        [Required(ErrorMessage = "Short description of the collection is not set")]
        [StringLength(300, MinimumLength = 3, 
            ErrorMessage = "Short description of the collection cannot be shorter than 3 and less than 100 symbols")]
        public string ShortDescription { get; set; }
        
        [Display(Name = "Theme of the collection")]
        [Required(ErrorMessage = "Theme of the collection is not set")]
        public string Theme { get; set; }

        [NotMapped]
        public static readonly List<string> AvailableThemes = new()
        {
            "Books", "Alcohol", "Electronics", "Fashion", "Sneakers", "VideoGames", "Food", "Marks", "Art"
        };

        public List<Item> Items { get; } = new();

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Collection Image")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Image File")]
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        
        public string ImageStorageName { get; set; }

        public bool FirstOptionalBoolFieldVisible => FirstOptionalBoolFieldName != null;

        public bool SecondOptionalBoolFieldVisible => SecondOptionalBoolFieldName != null;

        public bool ThirdOptionalBoolFieldVisible => ThirdOptionalBoolFieldName != null;

        public bool FirstOptionalDateTimeFieldVisible => FirstOptionalDateTimeFieldName != null;

        public bool SecondOptionalDateTimeFieldVisible => SecondOptionalDateTimeFieldName != null; 

        public bool ThirdOptionalDateTimeFieldVisible => ThirdOptionalDateTimeFieldName != null;

        public bool FirstOptionalNumberFieldVisible => FirstOptionalNumberFieldName != null;

        public bool SecondOptionalNumberFieldVisible => SecondOptionalNumberFieldName != null;

        public bool ThirdOptionalNumberFieldVisible => ThirdOptionalNumberFieldName != null;

        public bool FirstOptionalStringFieldVisible => FirstOptionalStringFieldName != null;

        public bool SecondOptionalStringFieldVisible => SecondOptionalStringFieldName != null;

        public bool ThirdOptionalStringFieldVisible => ThirdOptionalStringFieldName != null;

        public bool FirstOptionalTextFieldVisible => FirstOptionalTextFieldName != null;

        public bool SecondOptionalTextFieldVisible => SecondOptionalTextFieldName != null;

        public bool ThirdOptionalTextFieldVisible => ThirdOptionalTextFieldName != null;
        
        [Display(Name = "Set checkbox field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string FirstOptionalBoolFieldName { get; set; }

        [Display(Name = "Set checkbox field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string SecondOptionalBoolFieldName { get; set; }

        [Display(Name = "Set checkbox field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string ThirdOptionalBoolFieldName { get; set; }

        [Display(Name = "Set DateTime field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string FirstOptionalDateTimeFieldName { get; set; }

        [Display(Name = "Set DateTime field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string SecondOptionalDateTimeFieldName { get; set; }

        [Display(Name = "Set DateTime field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string ThirdOptionalDateTimeFieldName { get; set; }

        [Display(Name = "Set number field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string FirstOptionalNumberFieldName { get; set; }
        
        [Display(Name = "Set number field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string SecondOptionalNumberFieldName { get; set; }
        
        [Display(Name = "Set number field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string ThirdOptionalNumberFieldName { get; set; }

        [Display(Name = "Set string field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string FirstOptionalStringFieldName { get; set; }
        
        [Display(Name = "Set string field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string SecondOptionalStringFieldName { get; set; }
        
        [Display(Name = "Set string field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string ThirdOptionalStringFieldName { get; set; }

        [Display(Name = "Set text field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string FirstOptionalTextFieldName { get; set; }

        [Display(Name = "Set text field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string SecondOptionalTextFieldName { get; set; }

        [Display(Name = "Set text field")]
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name of the custom field cannot be shorter than 3 and less than 30 symbols")]
        public string ThirdOptionalTextFieldName { get; set; }
    }
}