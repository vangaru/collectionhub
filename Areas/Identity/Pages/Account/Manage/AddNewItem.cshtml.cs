using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionHub.Areas.Models;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class AddNewItem : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;
        private Item _item;
        
        [BindProperty]
        public InputItemModel Input { get; init; }

        public Collection Collection { get; private set; }

        public AddNewItem(UserManager<ApplicationUser> userManager, 
            ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
        }

        public IActionResult OnGet(int id)
        {
            Load(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            Load(id);

            if (!ModelState.IsValid) return Page();
            
            var tags = await ProcessTags();

            _item = new Item
            {
                Name = Input.Name, 
                Tags = tags,
                FirstOptionalBoolField = Input.FirstOptionalBoolField,
                SecondOptionalBoolField = Input.SecondOptionalBoolField,
                ThirdOptionalBoolField = Input.ThirdOptionalBoolField,
                FirstOptionalDateTimeField = Input.FirstOptionalDateTimeField.ToLocalTime(),
                SecondOptionalDateTimeField = Input.SecondOptionalDateTimeField.ToLocalTime(),
                ThirdOptionalDateTimeField = Input.ThirdOptionalDateTimeField.ToLocalTime(),
                FirstOptionalNumberField = Input.FirstOptionalNumberField,
                SecondOptionalNumberField = Input.SecondOptionalNumberField,
                ThirdOptionalNumberField = Input.ThirdOptionalNumberField,
                FirstOptionalStringField = Input.FirstOptionalStringField,
                SecondOptionalStringField = Input.SecondOptionalStringField,
                ThirdOptionalStringField = Input.ThirdOptionalStringField,
                FirstOptionalTextField = Input.FirstOptionalTextField,
                SecondOptionalTextField = Input.SecondOptionalTextField,
                ThirdOptionalTextField = Input.ThirdOptionalTextField
            };

            _dbContext.Items.Add(_item);
            
            Collection.Items.Add(_item);

            await _dbContext.SaveChangesAsync();

            return RedirectToPage();
        }

        private void Load(int id)
        {
            LoadCollection(id);
        }

        private void LoadCollection(int id)
        {
            Collection = _dbContext.Collections
                .Where(c => c.Id == id)
                .Include(c => c.Items)
                .ThenInclude(t => t.Tags)
                .ToList().FirstOrDefault();
        }

        private async Task<List<Tag>> ProcessTags()
        {
            var tagStrings = _tagFormatter.RemoveRepeatableTags(Input.Tags);

            var tagsList = await _tagFormatter.AddOrIncrementTags(tagStrings);

            return tagsList;
        }
    }
}