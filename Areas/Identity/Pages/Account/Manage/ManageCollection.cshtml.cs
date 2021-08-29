using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Areas.Identity.Pages.Account.Manage
{
    public class ManageCollection : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;

        public ManageCollection(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
        }
        
        public Collection Collection { get; private set; }

        public List<Item> Items { get; set; }

        public Dictionary<Item, string> TagDictionary { get; } = new();

        public int OptionalBoolFieldsCount { get; set; } = 0;

        public int OptionalDateTimeFieldsCount { get; set; } = 0;

        public int OptionalNumberFieldsCount { get; set; } = 0;

        public int OptionalStringFieldsCount { get; set; } = 0;

        public int OptionalTextFieldsCount { get; set; } = 0;

        public IActionResult OnGet(int id)
        {
            Load(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IEnumerable<string> selectedItemsIds, int id)
        {
            Load(id);
            foreach (var selectedItemId in selectedItemsIds)
            {
                if (!int.TryParse(selectedItemId, out var idNum)) continue;
                var itemToDelete = _dbContext.Items
                    .Include(i => i.Tags)
                    .First(i => i.Id == idNum);
                await DeleteItemIfNotNullAsync(itemToDelete);
            }
            return RedirectToPage();
        }
        
        public IActionResult OnPostSort(int id, string sortOrder)
        {
            Load(id);
            Items = sortOrder switch
            {
                "RecentItems" => Items.OrderByDescending(i => i.PublicationDate).ToList(),
                "OldestItems" => Items.OrderBy(i => i.PublicationDate).ToList(),
                "AlphabeticAsc" => Items.OrderBy(i => i.Name).ToList(),
                "AlphabeticDesc" => Items.OrderByDescending(i => i.Name).ToList(),
                _ => Items
            };
            return Page();
        }

        public IActionResult OnPostFilter(int id, string itemNameFilter)
        {
            Load(id);
            FilterByItemNameIfNotNull(itemNameFilter);
            return Page();
        }

        private void FilterByItemNameIfNotNull(string itemNameFilter)
        {
            if (itemNameFilter == null) return;
            Items = Items.Where(i => i.Name.Contains(itemNameFilter)).ToList();
        }

        private void Load(int id)
        {
            LoadCollection(id);

            LoadItems();

            LoadTagDictionary();
            
            LoadOptionalFieldsCount();
        }

        private void LoadCollection(int id)
        {
            Collection = _dbContext.Collections
                .Where(c => c.Id == id)
                .Include(c => c.Items)
                .ThenInclude(i => i.Tags)
                .FirstOrDefault();
        }

        private void LoadItems()
        {
            Items = Collection.Items.ToList();
        }

        private void LoadTagDictionary()
        {
            foreach (var item in Items)
            {
                var tagString = _tagFormatter.GetTagsString(item.Tags);
                TagDictionary.Add(item, tagString);
            }
        }

        private void LoadOptionalFieldsCount()
        {
            LoadOptionalBoolFieldsCount();
            LoadOptionalDateTimeFieldsCount();
            LoadOptionalNumberFieldsCount();
            LoadOptionalStringFieldsCount();
            LoadOptionalTextFieldsCount();
        }

        private void LoadOptionalBoolFieldsCount()
        {
            if (Collection.FirstOptionalBoolFieldVisible)
            {
                OptionalBoolFieldsCount++;
            }

            if (Collection.SecondOptionalBoolFieldVisible)
            {
                OptionalBoolFieldsCount++;
            }

            if (Collection.ThirdOptionalBoolFieldVisible)
            {
                OptionalBoolFieldsCount++;
            }
        }
        
        private void LoadOptionalDateTimeFieldsCount()
        {
            if (Collection.FirstOptionalDateTimeFieldVisible)
            {
                OptionalDateTimeFieldsCount++;
            }

            if (Collection.SecondOptionalDateTimeFieldVisible)
            {
                OptionalDateTimeFieldsCount++;
            }

            if (Collection.ThirdOptionalDateTimeFieldVisible)
            {
                OptionalDateTimeFieldsCount++;
            }
        }

        private void LoadOptionalNumberFieldsCount()
        {
            if (Collection.FirstOptionalNumberFieldVisible)
            {
                OptionalNumberFieldsCount++;
            }

            if (Collection.SecondOptionalNumberFieldVisible)
            {
                OptionalNumberFieldsCount++;
            }

            if (Collection.ThirdOptionalNumberFieldVisible)
            {
                OptionalNumberFieldsCount++;
            }
        }

        private void LoadOptionalStringFieldsCount()
        {
            if (Collection.FirstOptionalStringFieldVisible)
            {
                OptionalStringFieldsCount++;
            }

            if (Collection.SecondOptionalStringFieldVisible)
            {
                OptionalStringFieldsCount++;
            }

            if (Collection.ThirdOptionalStringFieldVisible)
            {
                OptionalStringFieldsCount++;
            }
        }

        private void LoadOptionalTextFieldsCount()
        {
            if (Collection.FirstOptionalTextFieldVisible)
            {
                OptionalTextFieldsCount++;
            }

            if (Collection.SecondOptionalTextFieldVisible)
            {
                OptionalTextFieldsCount++;
            }

            if (Collection.ThirdOptionalTextFieldVisible)
            {
                OptionalTextFieldsCount++;
            }
        }

        private async Task DeleteItemIfNotNullAsync(Item itemToDelete)
        {
            if (itemToDelete == null) return;
            _dbContext.Tags.RemoveRange(itemToDelete.Tags);
            _dbContext.Items.Remove(itemToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}