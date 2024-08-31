namespace SharedMomentsBackend.App.DB.Respositories.Base.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        Task Commit();
    }
}
