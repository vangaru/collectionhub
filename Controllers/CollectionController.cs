using System.Collections.Generic;
using System.Linq;
using CollectionHub.Areas.Identity.Pages.Account.Manage;
using CollectionHub.Data;
using CollectionHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;
        private CollectionPageViewModel _collectionPageViewModel;

        public CollectionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
        }

        public IActionResult Items(int collectionId, int pageNumber = 0)
        {
            var collection = _dbContext.Collections
                .Include(c => c.Items)
                .ThenInclude(i => i.Tags)
                .FirstOrDefault(c => c.Id == collectionId);
            SetCollectionPageViewModel(collection, pageNumber);
            return View(_collectionPageViewModel);
        }

        private void SetCollectionPageViewModel(Collection collection, int pageNumber)
        {
            const int itemsCountPerPage = 5;
            var pagination = new PaginationModel(collection.Items.Count, pageNumber, itemsCountPerPage);
            var author = GetCollectionAuthor(collection);
            var collectionItems = GetCollectionItems(collection, pagination);
            var itemTagsDictionary = GetItemTagsDictionary(collectionItems);
            _collectionPageViewModel = new CollectionPageViewModel(pagination, collection, author, collectionItems, itemTagsDictionary);
        }

        private ApplicationUser GetCollectionAuthor(Collection collection)
        {
            var author = _dbContext.ApplicationUsers
                .AsEnumerable().FirstOrDefault(u => u.Collections
                    .Exists(c => c.Id == collection.Id));
            return author;
        }

        private List<Item> GetCollectionItems(Collection collection, PaginationModel pagination)
        {
            var items = collection.Items
                .Skip(pagination.PageNumber * pagination.ItemsCountPerPage)
                .Take(pagination.ItemsCountPerPage).ToList();
            return items;
        }

        private Dictionary<Item, string> GetItemTagsDictionary(List<Item> items)
        {
            Dictionary<Item, string> itemTagsDictionary = new();
            foreach (var item in items)
            {
                var tagsString = _tagFormatter.GetTagsString(item.Tags);
                itemTagsDictionary[item] = tagsString;
            }
            
            return itemTagsDictionary;
        }
    }
}