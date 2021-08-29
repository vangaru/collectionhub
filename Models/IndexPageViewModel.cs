using System.Collections.Generic;
using CollectionHub.Data;

namespace CollectionHub.Models
{
    public class IndexPageViewModel
    {
        public PaginationModel PaginationModel { get; }
        public Dictionary<Item, Collection> ItemCollectionDictionary { get; }
        public Dictionary<Item, ApplicationUser> ItemUserDictionary { get; }
        public Dictionary<Item, string> ItemTagsDictionary { get; }
        public List<Collection> CollectionsWithMostItems { get; }

        public IndexPageViewModel(PaginationModel paginationModel, 
            Dictionary<Item, Collection> itemCollectionDictionary, 
            Dictionary<Item, ApplicationUser> itemUserDictionary,
            Dictionary<Item, string> itemTagsDictionary,
            List<Collection> collectionsWithMostItems)
        {
            PaginationModel = paginationModel;
            ItemCollectionDictionary = itemCollectionDictionary;
            ItemUserDictionary = itemUserDictionary;
            ItemTagsDictionary = itemTagsDictionary;
            CollectionsWithMostItems = collectionsWithMostItems;
        }
    }
}