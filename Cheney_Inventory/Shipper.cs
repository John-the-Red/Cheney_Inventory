using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_Inventory
{
    class Shipper
    {
        IShippable[] Ship = new IShippable[10];
        private IShippable shippable1;
        private int i = 0;
        public void Add(IShippable shippable) 
        {
             Ship[i] = shippable;
            shippable1 = shippable;
            i++;
        }
        public string Response()
        {
            return "1 " + shippable1.Product + " has been added";
        }
        public string AllBicycles()
        {
            int count = 0;
                for(int i=0;i<Ship.Length; i++)
                {
                if (Ship[i] != null)
                {
                    if (Ship[i].Product == "Bicycle")
                    {
                        count++;
                    }
                }
                }
            
            if (count == 0 || count > 1)
            {
                return count.ToString() + " Bicycles";
            }
            else
            {
                return count.ToString() + " Bicycle";
            }
        }
        public string AllLawn_Mowers()
        {
            int count = 0;
            for (int i = 0; i < Ship.Length; i++)
            {
                if (Ship[i] != null)
                {
                    if (Ship[i].Product == "Lawn Mower")
                    {
                        count++;
                    }
                }
            }

            if (count == 0 || count > 1)
            {
                return count.ToString() + " Lawn Mowers";
            }
            else
            {
                return count.ToString() + " Lawn Mower";
            }
        }
        public string AllBaseball_Gloves()
        {
            int count = 0;
            for (int i = 0; i < Ship.Length; i++)
            {
                if (Ship[i] != null)
                {
                    if (Ship[i].Product == "Baseball Glove")
                    {
                        count++;
                    }
                }
            }

            if (count == 0 || count > 1)
            {
                return count.ToString() + " Baseball Gloves";
            }
            else
            {
                return count.ToString() + " Baseball Glove";
            }
        }
        public string AllCrackers()
        {
            int count = 0;
            for (int i = 0; i < Ship.Length; i++)
            {
                if (Ship[i] != null)
                {
                    if (Ship[i].Product == "Crackers")
                    {
                        count++;
                    }
                }
            }
            return count.ToString() + " Crackers";
        }
        public string Charges()
        {
            decimal TotalCharges = 0M;
            for (int i = 0; i < Ship.Length; i++)
            {
                if (Ship[i] != null)
                {
                    TotalCharges += Ship[i].ShipCost;
                }
            }
            return "Total shipping cost for this order is " + string.Format("{0:C}",TotalCharges);
        }
    }
}
