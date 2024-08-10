namespace SharedMomentsBackend.App.Models.DTOs
{
    public class DefaultFilterParams:PaginateParams
    {
        public string Search { get; set; }
        public bool? Status { get; set; }
    }
}
