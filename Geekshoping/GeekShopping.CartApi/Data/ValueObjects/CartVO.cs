﻿using System.Collections.Generic;

namespace GeekShopping.CartApi.Data.ValueObjects
{
    public class CartVO
    {
        public CartHeaderVO CartHeader { get; set; }
        public IEnumerable<CartDetailVO> CartDetails { get; set;}
    }
}
