﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAA.Northwind.Mvc.WebUI.Models;
using AAA.Northwind.Mvc.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AAA.Northwind.Mvc.WebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };

            return View(model);
        }
    }
}
