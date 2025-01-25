using ShoppingClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass] 
    public sealed class CakeTest
    {



        [TestMethod]
        //[ExpectedException(typeof(InvalidFlavourException),"Invalid Flavour")]
        public void Test_CakeOrder()
        {
            bool expected = true;

            //Arrange
        Cake c=new Cake();
            c.Flavour = "Chocolate";
            c.Price = 100;
            c.QtyInKg = 2;
            bool actual = false;
    
            //Act
                 actual = c.CakeOrder();
           //Assert
                Assert.AreEqual(expected, actual);
           
         
          
           
           
            // Assert.AreEqual(expected, actual);



        }

    }
}
