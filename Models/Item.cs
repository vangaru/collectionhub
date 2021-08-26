using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollectionHub.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Display(Name = "Name of the item")]
        [Required(ErrorMessage = "Name of the item is not set")]
        [StringLength(30, MinimumLength = 3, 
            ErrorMessage = "Name of the item cannot be shorter than 3 and longer than 30 symbols")]
        public string Name { get; set; }

        public bool FirstOptionalBoolField { get; set; }
        
        public bool SecondOptionalBoolField { get; set; }
        
        public bool ThirdOptionalBoolField { get; set; }

        public DateTime FirstOptionalDateTimeField { get; set; }

        public DateTime SecondOptionalDateTimeField { get; set; }

        public DateTime ThirdOptionalDateTimeField { get; set; }

        public double FirstOptionalNumberField { get; set; }
        
        public double SecondOptionalNumberField { get; set; }
        
        public double ThirdOptionalNumberField { get; set; }

        public string FirstOptionalStringField { get; set; }
        
        public string SecondOptionalStringField { get; set; }
        
        public string ThirdOptionalStringField { get; set; }

        public string FirstOptionalTextField { get; set; }
        
        public string SecondOptionalTextField { get; set; }
        
        public string ThirdOptionalTextField { get; set; }
        
        public List<Tag> Tags { get; set; } = new();

        public DateTime PublicationDate { get; set; } = DateTime.Now;
    }
}