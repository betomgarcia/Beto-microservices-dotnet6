using GeekShopping.CartApi.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShopping.CartApi.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCoupon(string CouponCode, string token);
    }
}
