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
                FirstName = "Bildo",
                LastName="Baggins"  
            };

            string expected = "Baggins,Bildo";

            //--Act

            string actual=customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        public void Fullnamefirstempty

    }
}
