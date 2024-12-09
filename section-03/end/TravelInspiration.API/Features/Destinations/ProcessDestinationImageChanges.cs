using MediatR;
using TravelInspiration.API.Shared.Slices;

namespace TravelInspiration.API.Features.Destinations;

public sealed class ProcessDestinationImageChanges : ISlice
{
    public void AddEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapGet("api/processdestinationimagechanges",
             (IMediator mediator,
                CancellationToken cancellationToken) =>
             {
                 return mediator.Send(
                     new ProcessDestinationImageChangesQuery(),
                     cancellationToken);
             }); 
    }

    public sealed class ProcessDestinationImageChangesQuery() : IRequest<IResult>
    {
    }

    public sealed class MessageDto
    {
        public required string Action { get; set; }
        public required string BlobName { get; set; } 
    }

    public sealed class ProcessDestinationImageChangesHandler() :
       IRequestHandler<ProcessDestinationImageChangesQuery, IResult>
    {
        public Task<IResult> Handle(ProcessDestinationImageChangesQuery request,
            CancellationToken cancellationToken)
        {             
            // TODO
            return Task.FromResult(Results.Ok());
        }
    } 
} 