using DSU24.Models;

namespace DSU24.DAL
{
    public interface IDbRepository
    {
        Task<Sport> AddSportAsync(Sport sport);
        Task<IEnumerable<Season>> GetSeasonsAsync();
        Task<IEnumerable<Sport>> GetSportsAsync();
    }
}