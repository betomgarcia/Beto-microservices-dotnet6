using GeekShopping.CartApi.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartApi.Model
{
    [Table("cart_detail")]
    public class CartDetail : BaseEntity
    {
        public long CartHeaderId { get; set; }


        [ForeignKey("CartHeaderId")]
        public virtual CartHeader CartHeader { get; set; }

        public long ProductId { get; set; }


        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }


        [Column("Count")]

        public int Count { get; set; }
    }
}
