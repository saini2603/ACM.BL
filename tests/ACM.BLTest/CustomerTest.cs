using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullnameTestValid()
        {

            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Rohit",
                LastName="Saini"  
            };

            string expected = "Saini,Rohit";

            //--Act

            string actual=customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange

            Customer customer = new Customer
            {
                LastName = "Saini"

            };

            string expected = "Saini";

            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
