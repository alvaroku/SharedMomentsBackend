namespace SharedMomentsBackend.App.Models.DTOs
{
    public class PaginateParams
    {
        /// <summary>
        /// Número de la página solicitada.
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Tamaño de la página solicitada.
        /// </summary>
        public int PageSize { get; set; } = 10;
    }
}
