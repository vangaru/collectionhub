using System;
using System.IO;
using System.Threading.Tasks;
using CollectionHub.CloudStorage;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class AddNewCollection : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly ICloudStorage _cloudStorage;

        public AddNewCollection(UserManager<ApplicationUser> userManager, 
            ApplicationDbContext dbContext, ICloudStorage cloudStorage)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _cloudStorage = cloudStorage;
        }
        
        public ApplicationUser ApplicationUser { get; private set; }

        [BindProperty] 
        public Collection Collection { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            await LoadAsync();
            if (ApplicationUser == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await LoadAsync();

            if (!ModelState.IsValid) return Page();

            if (Collection.ImageFile != null)
            {
                await UploadFileAsync();
            }
                    
            _dbContext.Collections.Add(Collection);

            ApplicationUser.Collections.Add(Collection);
            
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("ManageCollections");
        }

        private async Task LoadAsync()
        {
            ApplicationUser = await _userManager.GetUserAsync(User);
        }

        private async Task UploadFileAsync()
        {
            var fileNameForStorage = FormFileName(Collection.Name, Collection.ImageFile.FileName);
            Collection.ImageUrl = await _cloudStorage.UploadFileAsync(Collection.ImageFile, fileNameForStorage);
            Collection.ImageStorageName = fileNameForStorage;
        }

        private static string FormFileName(string collectionName, string fileName)
        {
            var fileExtension = Path.GetExtension(fileName);
            var fileNameForStorage = $"{collectionName}-{DateTime.Now:yyyyMMddHHmmss}{fileExtension}";
            return fileNameForStorage;
        }
    }
}