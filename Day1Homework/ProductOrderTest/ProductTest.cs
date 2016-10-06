using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductOrder;
using System.Collections.Generic;
using ExpectedObjects;

namespace ProductOrderTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestMethodProductCount_number_3_field_Cost()
        {
            //arange         
            var DataIn = new DoIData();
            var target = new Product( DataIn);
            var number = 3;
            var fieldName = "Cost";
            var expected = new int[] { 6, 15, 24, 21 };           
           
            //act
            //IEnumerable<int> actual = target.GetResultSet(number, fieldName);
            var actual = target.ProductCount(number, fieldName).ToArray();

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
            
        }
        [TestMethod]
        public void TestMethodProductCount_number_4_field_Revenue()
        {
            //arange         
            var DataIn = new DoIData();
            var target = new Product(DataIn);
            var number = 4;
            var fieldName = "Revenue";
            var expected = new int[] { 50, 66, 60,};

            //act
            //IEnumerable<int> actual = target.GetResultSet(number, fieldName);
            var actual = target.ProductCount(number, fieldName).ToArray();

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }
    }
    public class DoIData : IDataIn
    {
        public IEnumerable<int> GetResultSet(string filename)
        { 
            if (filename == "Cost") { return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; }
            if (filename == "Revenue") { return new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 }; }
            return null;
        }

    }
}
