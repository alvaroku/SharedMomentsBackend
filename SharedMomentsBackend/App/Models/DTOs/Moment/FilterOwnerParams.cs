namespace SharedMomentsBackend.App.Models.DTOs.Moment
{
    public class FilterOwnerParams : DefaultFilterParams
    {
        public Guid? OwnerId { get; set; }
    }
    public class FilterMomentParams : FilterOwnerParams
    {
        public Guid? AlbumId { get; set; }
        public bool? HasAlbum { get; set; }
    }
}
