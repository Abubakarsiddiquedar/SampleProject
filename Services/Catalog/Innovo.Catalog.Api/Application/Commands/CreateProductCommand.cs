using Innovo.Catalog.Contracts.DataContracts;
using MediatR;

namespace Innovo.Catalog.Api.Application.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
    }
}
