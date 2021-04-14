using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Events;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap(); //Ondan ona ondan ona..
            CreateMap<Event, EventDetailVm>().ReverseMap(); //Ondan ona ondan ona..
            CreateMap<Category, CategoryDto>();
        }
    }
}
