using System;
using System.IO;
using System.Threading.Tasks;
using CollectionHub.Areas.Models;
using CollectionHub.CloudStorage;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class ManageCollectionFields : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICloudStorage _cloudStorage;

        public ManageCollectionFields(ApplicationDbContext dbContext, ICloudStorage cloudStorage)
        {
            _dbContext = dbContext;
            _cloudStorage = cloudStorage;
        }
        
        [BindProperty]
        public Collection Collection { get; set; }

        public IActionResult OnGet(int id)
        {
            LoadCollection(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            if (Collection.ImageFile != null)
            {
                if (Collection.ImageStorageName != null)
                {
                    await _cloudStorage.DeleteFileAsync(Collection.ImageStorageName);
                }

                await UploadFile();
            }

            _dbContext.Attach(Collection).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return RedirectToPage();
        }
        
        private void LoadCollection(int id)
        {
            Collection = _dbContext.Collections.Find(id);
        }
        
        private async Task UploadFile()
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