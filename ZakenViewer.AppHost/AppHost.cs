var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ZakenViewer_Server>("zakenviewer-server");

builder.Build().Run();
