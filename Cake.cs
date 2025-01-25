using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingClassLibrary
{
    public class Cake
    {
      public int  QtyInKg { get; set; }
public string Flavour { get; set; }
public double Price { get;set; }

        public double CalculatePrice()
        { 

        return QtyInKg * Price; 
        
        
        }


        public bool CakeOrder()
        {
            if (Flavour == "Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
            {
                if (QtyInKg > 0) {
                    return true;
                }
                throw new Exception("qty must be greater than 0");
                
            }
            throw new InvalidFlavourException("Invalid flavour");
        
        
        }
    }
}
