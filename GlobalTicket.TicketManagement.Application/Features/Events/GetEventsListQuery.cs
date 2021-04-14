using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    //Bu sınıf bir mesaj yapmalıyım !! ve IRequest'ı kullanmalı ...
    //Bilgi almak istediğim olayın kimliği...
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {
    }
}
