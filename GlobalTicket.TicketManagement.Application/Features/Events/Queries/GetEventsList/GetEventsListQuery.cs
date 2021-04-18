using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    //Bu sınıf bir mesaj yapmalıyım !! ve IRequest'ı kullanmalı ...
    //Bilgi almak istediğim olayın kimliği...
    //oluşturulması gereken yeni olay hakkında mesaj
    public class GetEventsListQuery: IRequest<List<EventListVm>>
    {
    }
}
