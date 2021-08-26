using System.Collections.Generic;
using System.Linq;
using CollectionHub.Areas.Identity.Pages.Account.Manage;
using CollectionHub.Data;
using Microsoft.AspNetCore.Mvc;
using CollectionHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CollectionHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TagFormatter _tagFormatter;
        private readonly List<Item> _items;
        private readonly List<ApplicationUser> _applicationUsers;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _tagFormatter = new TagFormatter(_dbContext);
            _items = _dbContext.Items
                .Include(i => i.Tags)
                .OrderByDescending(i => i.PublicationDate).ToList();
            _applicationUsers = _dbContext.ApplicationUsers
                .Include(u => u.Collections)
                .ThenInclude(c => c.Items)
                .ThenInclude(i => i.Tags).ToList();
        }

        public IActionResult Index()
        {
            ViewData["ItemCollectionDictionary"] = GetItemCollectionDictionary();

            ViewData["ItemUserDictionary"] = GetItemUserDictionary();
                
            ViewData["ItemTagsDictionary"] = GetItemTagsDictionary();

            ViewData["CollectionsWithMostItems"] = GetCollectionsWithMostItems();

            return View();
        }

        private Dictionary<Item, Collection> GetItemCollectionDictionary()
        {
            Dictionary<Item, Collection> itemCollectionDictionary = new();
            foreach (var item in _items)
            {
                itemCollectionDictionary[item] = _dbContext.Collections
                    .FirstOrDefault(c => c.Items.Contains(item));
            }
            
            return itemCollectionDictionary;
        }

        private Dictionary<Item, ApplicationUser> GetItemUserDictionary()
        {
            Dictionary<Item, ApplicationUser> itemUserDictionary = new();
            foreach (var item in _items)
            {
                itemUserDictionary[item] = _applicationUsers
                    .FirstOrDefault(u => u.Collections
                        .Exists(c => c.Items
                            .Contains(item)));
            }

            return itemUserDictionary;
        }

        private Dictionary<Item, string> GetItemTagsDictionary()
        {
            Dictionary<Item, string> itemTagsDictionary = new();
            foreach (var item in _items)
            {
                var tagsString = _tagFormatter.GetTagsString(item.Tags);
                itemTagsDictionary[item] = tagsString;
            }
            
            return itemTagsDictionary;
        }

        private List<Collection> GetCollectionsWithMostItems()
        {
            const int amountOfCollectionsToDisplay = 5;
            var collectionsWithMostItems = _dbContext.Collections
                .OrderByDescending(c => c.Items.Count).Take(amountOfCollectionsToDisplay).ToList();
            
            return collectionsWithMostItems;
        }
    }
}