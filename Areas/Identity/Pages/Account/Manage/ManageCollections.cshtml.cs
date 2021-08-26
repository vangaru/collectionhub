using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class ManageCollections : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;
        
        public ManageCollections(UserManager<ApplicationUser> userManager, 
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }
        
        public List<Collection> Collections { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            await LoadAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IEnumerable<string> selectedCollectionsIds)
        {
            await LoadAsync();
            foreach (var selectedCollectionId in selectedCollectionsIds)
            {
                    if (!int.TryParse(selectedCollectionId, out var id)) continue;
                    var collectionToDelete = _dbContext.Collections
                        .Include(c => c.Items)
                        .ThenInclude(i => i.Tags)
                        .First(c => c.Id == id);
                    await DeleteCollectionIfNotNullAsync(collectionToDelete);
            }
            
            return RedirectToPage();
        }

        private async Task LoadAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            Collections = _dbContext.ApplicationUsers
                .Where(u => u.Id == user.Id)
                .Include(u => u.Collections)
                .ThenInclude(c => c.Items)
                .ToList().FirstOrDefault()
                ?.Collections;
        }

        private async Task DeleteCollectionIfNotNullAsync(Collection collectionToDelete)
        {
            if (collectionToDelete == null) return;
            _dbContext.Items.RemoveRange(collectionToDelete.Items);
            _dbContext.Collections.Remove(collectionToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}