using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class OrderServices : IOrderServices
    {

        private readonly IDbService _dbservice;

        public OrderServices(IDbService dbService) {

            _dbservice = dbService;
        
        }
        public async Task<List<Orders>> GetOrders()
        {
            var orderList = await _dbservice.GetAll<Orders>("SELECT * FROM public.orders", new { });
            return orderList;

        }

        public async Task<bool> CreateOrder(Orders orders)
        {
            try
            {
                var result = await _dbservice.Insert<int>("INSERT INTO public.orders (orderid,ordername,orderdetails) VALUES (@orderid,@ordername,@orderdetails)", orders);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
      
    }
}
