namespace SharedMomentsBackend.App.Models.DTOs.Moment
{
    public class FilterOwnerParams : DefaultFilterParams
    {
        public Guid OwnerId { get; set; }
    }
}
