using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;

namespace SharedMomentsBackend.App.DB.Respositories.Base.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext Context { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
