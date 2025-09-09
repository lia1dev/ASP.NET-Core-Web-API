using Domain.Entities.Journals;
using Domain.Entities.Pager;

namespace Data.Services.Journals
{
    public interface IJournalService
    {
        Task<Journal> GetJournalByIdAsync(long id);
        Task<PageList<Journal>> SearchByFilterAsync(int skip, int take, JournalFilter? filter = null);
    }
}