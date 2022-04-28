using GeekShopping.CouponApi.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CouponApi.Model.Context
{
    public class MySqlContext : DbContext
    {

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {}

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 1,
                CouponCode = "MAGNO_2022_10",
                DiscountAmount = 10
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 2,
                CouponCode = "MAGNO_2022_15",
                DiscountAmount = 15
            });
        }

    }
}
