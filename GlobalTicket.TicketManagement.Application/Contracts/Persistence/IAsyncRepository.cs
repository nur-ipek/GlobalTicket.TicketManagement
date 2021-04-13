using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T:class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T Entitiy);
        Task<T> UpdateAsync(T Entitiy);
        Task<T> DeleteAsync(T Entity);


    }
}
