﻿using System;
using System.Collections.Generic;
using System.Text;
using AAA.Core.Entities;

namespace AAA.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
