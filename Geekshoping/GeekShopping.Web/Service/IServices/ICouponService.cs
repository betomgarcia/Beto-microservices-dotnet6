using GeekShopping.Web.Models;
using System.Threading.Tasks;

namespace GeekShopping.Web.Service.IServices
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
    }
}
