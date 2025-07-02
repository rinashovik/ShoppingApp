var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.ShoppingBlazorApp_ApiService>("apiservice");

builder.AddProject<Projects.ShoppingBlazorApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
