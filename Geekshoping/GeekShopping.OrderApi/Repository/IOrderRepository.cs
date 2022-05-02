using GeekShopping.OrderApi.Model;
using System.Threading.Tasks;

namespace GeekShopping.CartApi.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task UpdateOrderPaymentStatus(long orderHeaderId, bool paid);
    }
}
