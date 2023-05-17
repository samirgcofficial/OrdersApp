using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IOrderServices
    {
        Task<bool> CreateOrder( Orders orders);
        Task<List<Orders>> GetOrders();
    }
}
