using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository: IAsyncRepository<Event>
    {
    }
}
