using GlobalTicket.TicketManagement.Application.Features.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Commands
{
    //??????
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {
            
        }
        public CreateCategoryDto Category { get; set; }
    }
}
