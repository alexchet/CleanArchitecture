using CleanArchitecture.Application.ItemsAggregate.Responses;
using MediatR;

namespace CleanArchitecture.Application.ItemsAggregate.Commands.CreateItem
{
    public class CreateItemCommand : IRequest<ItemResponse>
    {
        public ItemResponse? Response { get; set; }   
    }

    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemResponse>
    {
        public Task<ItemResponse> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
