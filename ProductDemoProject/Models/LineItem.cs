using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemoProject.Models
{
    internal class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product product { get; set; }

        public LineItem(int id,int quantity,Product product) 
        { 
            Id = id;
            Quantity = quantity;
            this.product = product;
        }
        public double CalculateLineItemCost()
        {
            return Quantity * product.CalculateDiscountedPrice();
        }
    }
}
