namespace SharedMomentsBackend.App.Models.DTOs
{
    public class PaginateResponse<T>
    {
        public IEnumerable<T> List { get; set; } = Enumerable.Empty<T>();
        public int Total { get; set; }
        public int Page { get; set; }
        public int Take { get; set; }
    }
}
