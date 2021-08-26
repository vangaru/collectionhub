using System.ComponentModel.DataAnnotations;
using CollectionHub.Models;

namespace CollectionHub.Areas.Models
{
    public class InputItemModel : Item
    {
        [Display(Name = "Tags")]
        [Required(ErrorMessage = "Tags of the item is not set")]
        [StringLength(50, MinimumLength = 3, 
            ErrorMessage = "Tag input field length cannot be less than 3 and more than 50 symbols")]
        public new string Tags { get; init; }
    }
}