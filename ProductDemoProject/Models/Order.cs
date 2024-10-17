using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemoProject.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }

        public List<LineItem> items { get; set; }

        public Order(int id,DateTime date) 
        { 
            Id = id;
            Date = date;
            items = new List<LineItem>();
        }
        public double CalculateOrderPrice()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.CalculateLineItemCost();
            }
            return total;
        }

    }
}
