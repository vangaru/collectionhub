using System.Collections.Generic;
using CollectionHub.Data;

namespace CollectionHub.Models
{
    public class CollectionPageViewModel
    {
        public PaginationModel PaginationModel { get; }
        public Collection Collection { get; }
        public ApplicationUser Author { get; }
        public List<Item> Items { get; }
        public Dictionary<Item, string> ItemTagsDictionary { get; }

        public CollectionPageViewModel(PaginationModel paginationModel, 
            Collection collection, ApplicationUser author, 
            List<Item> items, Dictionary<Item, string> itemTagsDictionary)
        {
            PaginationModel = paginationModel;
            Collection = collection;
            Author = author;
            Items = items;
            ItemTagsDictionary = itemTagsDictionary;
        }
    }
}