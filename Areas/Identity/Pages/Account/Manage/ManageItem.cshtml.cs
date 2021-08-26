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
    public class ManageItem : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;

        public ManageItem(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
        }

        [BindProperty]
        public InputItemModel Input { get; init; }
        public string TagsString { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await LoadAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await LoadAsync(id);
            
            if (!ModelState.IsValid) return Page();
            
            var tags = await ProcessTags();

            Item.Name = Input.Name;
            Item.Tags = tags;

            await _dbContext.SaveChangesAsync(); 
            
            return RedirectToPage();
        }

        private async Task LoadAsync(int id)
        {
            await LoadApplicationUser();
            LoadItem(id);
            LoadTagsString();
        }

        private async Task LoadApplicationUser()
        {
            ApplicationUser = await _userManager.GetUserAsync(User);
        }

        private void LoadItem(int id)
        {
            Item = _dbContext.Items
                .Where(i => i.Id == id)
                .Include(i => i.Tags)
                .FirstOrDefault();
        }

        private void LoadTagsString()
        {
            TagsString = _tagFormatter.GetTagsString(Item.Tags);
        }
        
        private async Task<List<Tag>> ProcessTags()
        {
            var tagStrings = _tagFormatter.RemoveRepeatableTags(Input.Tags);

            var tagsList = await _tagFormatter.AddOrIncrementTags(tagStrings);

            return tagsList;
        }
    }
}