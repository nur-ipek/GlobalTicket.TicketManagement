using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    //Bu sınıf, kullanıcaya entities dönmektense istenilen alanların dönülmesini sağlayan sınıftır.
    public class EventListVm 
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
