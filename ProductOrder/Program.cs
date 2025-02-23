using Ecommerce.ProductOrder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGrpcService<OrderProductService>();

app.Run();
