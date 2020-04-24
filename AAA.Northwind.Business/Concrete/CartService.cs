﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AAA.Northwind.Business.Abstact;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Business.Concrete
{
    public class CartService:ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine{Product = product,Quantity = 1});
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
