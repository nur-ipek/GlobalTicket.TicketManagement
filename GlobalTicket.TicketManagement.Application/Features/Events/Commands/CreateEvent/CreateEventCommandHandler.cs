using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public CreateEventCommandHandler(IMapper mapper,IEventRepository eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;

        }
        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            CreateEventCommandValidator validator = new CreateEventCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new  Exceptions.ValidationException(validationResult);

            var @event = _mapper.Map<Event>(request); //request'ten Event'a gitmek istiyorum.

            @event = await _eventRepository.AddAsync(@event);

            return @event.EventId; //yeni oluşturduğum olayın Guid'ini geri döndürüyorum.
        }
    }
}
