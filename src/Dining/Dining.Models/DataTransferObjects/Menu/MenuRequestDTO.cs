using MediatR;

namespace Dining.Models.DataTransferObjects
{
    public record MenuRequestDTO : IRequest<MenuResponseDTO>;
    
}
