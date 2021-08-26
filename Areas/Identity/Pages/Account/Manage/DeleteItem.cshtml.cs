using System.Linq;
using System.Threading.Tasks;
using CollectionHub.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class DeleteItem : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteItem(UserManager<ApplicationUser> userManager, 
            ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IActionResult> OnGetAsync(int id)
        {
            await DeleteItemById(id);
            return RedirectToPage("ManageCollections");
        }

        private async Task DeleteItemById(int id)
        {
            var item = _dbContext.Items
                .Include(i => i.Tags)
                .FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _dbContext.Tags.RemoveRange(item.Tags);
                _dbContext.Items.Remove(item);
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}