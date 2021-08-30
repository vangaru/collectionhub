using System.Collections.Generic;
using System.Linq;
using CollectionHub.Areas.Identity.Pages.Account.Manage;
using CollectionHub.Data;
using Microsoft.AspNetCore.Mvc;
using CollectionHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;
        private readonly List<Item> _items;
        private readonly List<ApplicationUser> _applicationUsers;

        public HomeController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
            _items = _dbContext.Items
                .Include(i => i.Tags)
                .OrderByDescending(i => i.PublicationDate).ToList();
            _applicationUsers = _dbContext.ApplicationUsers
                .Include(u => u.Collections)
                    .ThenInclude(c => c.Items)
                        .ThenInclude(i => i.Tags)
                .Include(u => u.Collections)
                    .ThenInclude(c => c.Items).ToList();
        }

        public IActionResult Index(int pageNumber = 0)
        {
            var indexPageViewModel = GetIndexPageViewModel(pageNumber);
            
            return View(indexPageViewModel);
        }

        private IndexPageViewModel GetIndexPageViewModel(int pageNumber)
        {
            const int itemsCountPerPage = 5;
            var pagination = new PaginationModel(_dbContext.Items.Count(), pageNumber, itemsCountPerPage);
            
            var items = _items.Skip(pagination.PageNumber * pagination.ItemsCountPerPage)
                .Take(pagination.ItemsCountPerPage).ToList();

            var itemCollectionDictionary = GetItemCollectionDictionary(items);

            var itemUserDictionary = GetItemUserDictionary(items);
                
            var itemTagsDictionary = GetItemTagsDictionary(items);

            var collectionsWithMostItems = GetCollectionsWithMostItems();

            var indexPageViewModel = new IndexPageViewModel(pagination, itemCollectionDictionary, itemUserDictionary,
                itemTagsDictionary, collectionsWithMostItems);

            return indexPageViewModel;
        }

        private Dictionary<Item, Collection> GetItemCollectionDictionary(List<Item> items)
        {
            Dictionary<Item, Collection> itemCollectionDictionary = new();
            foreach (var item in items)
            {
                itemCollectionDictionary[item] = _dbContext.Collections
                    .FirstOrDefault(c => c.Items.Contains(item));
            }
            
            return itemCollectionDictionary;
        }

        private Dictionary<Item, ApplicationUser> GetItemUserDictionary(List<Item> items)
        {
            Dictionary<Item, ApplicationUser> itemUserDictionary = new();
            foreach (var item in items)
            {
                itemUserDictionary[item] = _applicationUsers
                    .FirstOrDefault(u => u.Collections
                        .Exists(c => c.Items
                            .Contains(item)));
            }

            return itemUserDictionary;
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

        private List<Collection> GetCollectionsWithMostItems()
        {
            const int amountOfCollectionsToDisplay = 3;
            var collectionsWithMostItems = _dbContext.Collections
                .OrderByDescending(c => c.Items.Count).Take(amountOfCollectionsToDisplay).ToList();
            
            return collectionsWithMostItems;
        }
    }
}