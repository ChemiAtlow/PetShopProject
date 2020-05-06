namespace PetShopProject.Models
{
    /// <summary>
    /// A helper class for holding data for the pagination.
    /// </summary>
    public class PaginationData
    {
        /// <summary>
        /// The current page user is on.
        /// </summary>
        public int CurrentPage { get; }
        /// <summary>
        /// The previous page of data.
        /// </summary>
        public int PreviousPage => CurrentPage - 1;
        /// <summary>
        /// The next page of data.
        /// </summary>
        public int NextPage => CurrentPage + 1;
        /// <summary>
        /// Last page available for current data.
        /// </summary>
        public int LastPage { get; }
        /// <summary>
        /// Is there a previous page.
        /// </summary>
        public bool HasPreviousPage => CurrentPage > 1;
        /// <summary>
        /// Is there a next page.
        /// </summary>
        public bool HasNextPage => CurrentPage + 1 <= LastPage;

        /// <summary>
        /// Create a new instance of pagination data.
        /// </summary>
        /// <param name="currentPage">The current page of returned info.</param>
        /// <param name="lastPage">The last page available.</param>
        public PaginationData(int currentPage, int lastPage)
        {
            CurrentPage = currentPage;
            LastPage = lastPage;
        }
    }
}
