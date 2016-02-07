using System;
using System.Threading.Tasks;

using CalienteExpress.Shared.Model;
using CalienteExpress.Shared.Model.Requests;
using CalienteExpress.Shared.Model.Responses;

using ModernHttpClient;

namespace CalienteExpress.Shared.Service
{
    public static class ApiService
    {
        public static Task<OrderResponse> CreateOrder(CreateOrderRequest request)
        {
            return Task.Run(() => { 
                return new OrderResponse();  
            }); 
        }

        public static Task<MenuResponse> GetMenu()
        {
            return Task.Run(() =>
            {
                return new MenuResponse();
            });
        }
    }
}
