using System;
using ConverterController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    [TestClass]
    public class NumberToText
    {
        [TestMethod]
        public void TestingNumberToText()
        {
            EnglishDictionary.LoadNumbers();

            Number numberClass = new Number();

            //I nee a function to generate random numbers in the valid range
            object[] argumentsNaturalTeens = new object[] { "137" };

            PrivateObject privateObject = new PrivateObject(numberClass);
            object resultNaturalTeens = privateObject.Invoke("CallToText", argumentsNaturalTeens);
    


            Assert.AreEqual("one hundred thirty seven ", (string)resultNaturalTeens);


            
            //hOW TO MANAGE THE FAILS??
           // Assert.Fail("failed " + (string)resultNaturalTeens);
            
      
        }
    }
}
