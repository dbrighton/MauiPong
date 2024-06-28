var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Pong_API>("pong-api");

builder.Build().Run();
