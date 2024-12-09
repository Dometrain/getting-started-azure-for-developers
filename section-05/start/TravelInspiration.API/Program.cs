using TravelInspiration.API;
using TravelInspiration.API.Shared.Slices;
using Microsoft.Extensions.Azure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddProblemDetails();
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor(); 
   
builder.Services.RegisterApplicationServices();
builder.Services.RegisterPersistenceServices(builder.Configuration);
builder.Services.AddAzureClients(clientBuilder =>
{
    clientBuilder.AddBlobServiceClient(builder.Configuration["ConnectionStrings:TravelInspirationStorageConnectionString:blobServiceUri"]!).WithName("ConnectionStrings:TravelInspirationStorageConnectionString");
    clientBuilder.AddQueueServiceClient(builder.Configuration["ConnectionStrings:TravelInspirationStorageConnectionString:queueServiceUri"]!).WithName("ConnectionStrings:TravelInspirationStorageConnectionString");
    clientBuilder.AddTableServiceClient(builder.Configuration["ConnectionStrings:TravelInspirationStorageConnectionString:tableServiceUri"]!).WithName("ConnectionStrings:TravelInspirationStorageConnectionString");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler();
}
app.UseStatusCodePages();
 
app.MapSliceEndpoints();

app.Run();