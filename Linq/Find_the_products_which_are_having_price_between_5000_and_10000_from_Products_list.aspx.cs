using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public partial class Find_the_products_which_are_having_price_between_5000_and_10000_from_Products_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Products> listProducts = new List<Products>();
            listProducts.Add(new Products { ProductName = "Mobile", Category = "Electronics", Price = 6000 });
            listProducts.Add(new Products { ProductName = "Fridge", Category = "Electronics", Price = 12000 });
            listProducts.Add(new Products { ProductName = "Chair", Category = "HomeNeeds", Price = 1000 });
            listProducts.Add(new Products { ProductName = "Table", Category = "HomeNeeds", Price = 6000 });
            listProducts.Add(new Products { ProductName = "T-Shirt", Category = "Clothes", Price = 1500 });
            listProducts.Add(new Products { ProductName = "Jeans", Category = "Clothes", Price = 3500 });

            var proudcts = from products in listProducts
                           where products.Price > 5000 && products.Price < 10000
                           orderby products.Price
                           select new { products.ProductName, products.Category, products.Price };
            gv1.DataSource = proudcts;
            gv1.DataBind();

        }
    }
    public class Products
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }

}