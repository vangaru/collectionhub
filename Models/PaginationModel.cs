using System;

namespace CollectionHub.Models
{
    public class PaginationModel
    {
        private readonly int _totalPagesCount;
        public int PageNumber { get; }
        public int ItemsCountPerPage { get; set; }

        public PaginationModel(int itemsCount, int pageNumber, int itemsCountPerPage)
        {
            PageNumber = pageNumber;
            ItemsCountPerPage = itemsCountPerPage;
            _totalPagesCount = (int)Math.Ceiling((float)itemsCount / ItemsCountPerPage);
        }

        public bool HasPreviousPage => PageNumber > 0;

        public bool HasNextPage => PageNumber < _totalPagesCount - 1;
    }
}