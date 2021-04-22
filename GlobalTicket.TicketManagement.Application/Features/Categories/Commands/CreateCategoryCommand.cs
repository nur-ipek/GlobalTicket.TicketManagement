using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse> //Event yazarken Guid döndürmüştük.
    {
        public string Name { get; set; }
    }
}
