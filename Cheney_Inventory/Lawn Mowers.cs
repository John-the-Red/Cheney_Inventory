﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_Inventory
{
    class Lawn_Mowers : IShippable
    {
        private decimal _shipCost;
        private string _product;
        
        public Lawn_Mowers(string Product, decimal ShipCost)
        {
            _product = Product;
            _shipCost = ShipCost;
        }
        public decimal ShipCost
        {
            get { return _shipCost; }
        }


        public string Product
        {
            get { return _product; }
        }
    }
}
