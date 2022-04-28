using AutoMapper;
using GeekShopping.CouponApi.Data.ValueObjects;
using GeekShopping.CouponApi.Model.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GeekShopping.CouponApi.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public CouponRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<CouponVO> GetCouponByCouponCode(string couponCode)
        {
            var coupon = await _context.Coupons.FirstOrDefaultAsync(c => c.CouponCode == couponCode);
            return _mapper.Map<CouponVO>(coupon);
        }
    }
}
