using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandValidator: AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
                 RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{Property} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{Property} must not exceed 100 characters.");
        }
    }
}
