using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    //MediatR:
    // Özet: Bir istek için bir işleyici tanımlar
    // Parametreleri yazın:
    // TRequest:
    // İşlenecek istek türü
    // TResponse:İşleyiciden gelen yanıtın türü

    // IRequestHandler<Mesaj tipim,EventListVm döndürecek listem>

    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        //// Özet:
        //// Bir isteği ele alır
        //// Parametreler:
        ////   istek:Talep
        //// cancellationToken: İptal belirteci
        //// İadeler:İstekten yanıt

        //Metod çağırılırken ihtiyacım olacaklar...
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        //Mesajı işleyeceğim yöntemi uyguluyorum..
        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date); //Burada aldığımız tüm varlıkları kullanıcıya döndürmek istemiyorum.
            return _mapper.Map<List<EventListVm>>(allEvents); // Bu sebeple bu satır sadece istediğimiz varlıkları döndürüyor.
        }
    }
}
