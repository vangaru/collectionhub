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

        public ManageItem(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }
        public ApplicationUser ApplicationUser { get; set; }
        
        [BindProperty]
        public Item Item { get; set; }
        public Collection Collection { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await LoadAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _dbContext.Attach(Item).State = EntityState.Modified;
            
            await _dbContext.SaveChangesAsync(); 
            
            return RedirectToPage();
        }

        private async Task LoadAsync(int id)
        {
            await LoadApplicationUser();
            LoadItem(id);
            LoadCollection(); ;
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

        private void LoadCollection()
        {
            Collection = _dbContext.Collections.FirstOrDefault(c => c.Items.Contains(Item));
        }
    }
}