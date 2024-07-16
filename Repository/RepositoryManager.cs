using Lucky.WebAPI.Data;
using Lucky.WebAPI.Repository.Contract;

namespace Lucky.WebAPI.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly LuckyDbContext _luckyDbContext;

        public RepositoryManager(LuckyDbContext luckyDbContext)
        {
            _luckyDbContext = luckyDbContext;
        }
        public async Task SaveAsync()
        {
            await _luckyDbContext.SaveChangesAsync();
        }
    }
}
