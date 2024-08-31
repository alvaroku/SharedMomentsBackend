namespace SharedMomentsBackend.App.Models.DTOs
{
    public class PaginateResponse<T>
    {
        public IEnumerable<T> List { get; set; } = Enumerable.Empty<T>();
        public int TotalRecords { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set;}
    }
}
