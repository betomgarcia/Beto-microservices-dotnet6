using GeekShopping.CouponApi.Data.ValueObjects;
using System.Threading.Tasks;

namespace GeekShopping.CouponApi.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string CouponCode);
    }
}
