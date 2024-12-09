using MediatR;
using TravelInspiration.API.Shared.Slices;

namespace TravelInspiration.API.Features.Destinations;

public class UpdateDestinationImages : ISlice
{
    public void AddEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapPut("api/destinations/{destinationId}/images",
            (int destinationId,
            UpdateDestinationImagesCommand updateDestinationImagesCommand,
            IMediator mediator,
            CancellationToken cancellationToken) =>
            {
                // make sure the destinationId from the Uri is used
                updateDestinationImagesCommand.DestinationId = destinationId;
                return mediator.Send(
                  updateDestinationImagesCommand,
                  cancellationToken);
            });
    }

    public sealed class UpdateDestinationImagesCommand : IRequest<IResult>
    {
        public sealed class ImageToUpdate
        {
            public required string Name { get; set; }
            public required string ImageBytes { get; set; }
        }
        public int DestinationId { get; set; }
        public List<ImageToUpdate> ImagesToUpdate { get; set; } = [];
    }


    public sealed class UpdateDestinationImagesCommandHandler(IConfiguration configuration) :
        IRequestHandler<UpdateDestinationImagesCommand, IResult>
    {
        private readonly IConfiguration _configuration = configuration;
 
        public Task<IResult> Handle(UpdateDestinationImagesCommand request,
            CancellationToken cancellationToken)
        { 
            // TODO implementation
            return Task.FromResult(Results.Ok());
        }
    }
}
