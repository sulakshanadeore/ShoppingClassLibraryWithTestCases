using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingClassLibrary
{
    public class ProductUitlity
    {
        static List<Products> products = new List<Products>() 
        { 
           new  Products {ProductID=1,ProductName="Tea" ,Price=10},
           new  Products {ProductID=2,ProductName="Coffee",Price=20 },
           new  Products {ProductID=3,ProductName="Green Tea",Price=30 },
           new  Products {ProductID=4,ProductName="Black Tea",Price=40 }


        };

        public Products FindProduct(int id)
        {

            Products p1=products.Find(p => p.ProductID == id);
            return p1;
        
        }


        public string GetProductName(int id)
        { 
        Products p1=products.Find(p=>p.ProductID == id);
            return p1.ProductName;
        
        }

    }
}
