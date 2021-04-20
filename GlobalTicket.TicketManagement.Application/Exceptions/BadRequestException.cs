using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Exceptions
{
    //ApplicationException: Uygulama tanımlı istisnalar için temel sınıf görevi görür.
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message): base(message)
        {

        }
    }
}
