using CleanArchitecture.Application.ItemsAggregate.Responses;
using MediatR;

namespace CleanArchitecture.Application.ItemsAggregate.Queries
{
    public class GetItemQuery : IRequest<ItemResponse>
    {
        public int Id { get; set; }
    }
}
