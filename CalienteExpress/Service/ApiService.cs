using System;
using System.Threading.Tasks;

using CalienteExpress.IOS.Model;
using CalienteExpress.IOS.Model.Requests;
using CalienteExpress.IOS.Model.Responses;

using ModernHttpClient;

namespace CalienteExpress.IOS.Service
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
