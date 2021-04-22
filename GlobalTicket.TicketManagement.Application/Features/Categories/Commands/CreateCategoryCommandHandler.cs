using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
    {
        private readonly IAsyncRepository<Category> _categoryRepostory;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository)
        {
            _categoryRepostory = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            CreateCategoryCommandResponse createCategoryCommandResponse = new CreateCategoryCommandResponse();
            CreateCategoryCommandValidator validator = new CreateCategoryCommandValidator();
           var validationResult = await validator.ValidateAsync(request);

           if( validationResult.Errors.Count >0)
            {
                createCategoryCommandResponse.Success = false;
                createCategoryCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createCategoryCommandResponse.Success)
                {
                    var category = new Category() { Name = request.Name };
                    category= await _categoryRepostory.AddAsync(category); //??
                    createCategoryCommandResponse.Category = _mapper.Map<CreateCategoryDto>(category);

                }
                return createCategoryCommandResponse;
          
            
        }
    }
}
