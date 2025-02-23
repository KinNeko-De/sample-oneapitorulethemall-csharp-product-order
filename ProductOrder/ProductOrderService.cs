using Grpc.Core;
using Kindatta.Ecommerce.ProductOrder.V1;

namespace Ecommerce.ProductOrder;

public class OrderProductService : Kindatta.Ecommerce.ProductOrder.V1.OrderProductService.OrderProductServiceBase
{
    public override async Task<OrderProductResponse> OrderProduct(OrderProductRequest request,
        ServerCallContext context)
    {
        var productOrdered = new ProductOrdered()
        {
            RequestId = request.RequestId
        };

        await SaveRequestAndEventInOneTransaction(request, productOrdered);

        var response = new OrderProductResponse();
        return response;
    }

    private Task SaveRequestAndEventInOneTransaction(OrderProductRequest request, ProductOrdered productOrdered)
    {
        // TODO : Save request and event in one database transaction
        // TODO : After saving, publish the event to the message broker
        return Task.CompletedTask;
    }
}