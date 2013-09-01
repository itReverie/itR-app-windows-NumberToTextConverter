
using System;
using ConverterController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    [TestClass]
    public class NumbersDictionary
    {

        [TestMethod()]
        public  void TestingNumbersToText( )
        {
            //use catch assert exception
            EnglishDictionary.LoadNumbers();

            Number numberClass = new Number();
            
            object[] argumentsNaturalTeens = new object[] { 1, EnglishDictionary.NaturalTeenNumbers  };
            object[] argumentsTens = new object[] { 3, EnglishDictionary.TenNumbers };
            object[] argumentsScale = new object[] { 4, EnglishDictionary.ScaleNumbers };

            PrivateObject privateObject = new PrivateObject(numberClass);
            object resultNaturalTeens = privateObject.Invoke("NumberToText", argumentsNaturalTeens);
            object resultTens = privateObject.Invoke("NumberToText", argumentsTens);
      
            
            Assert.AreEqual("one ", (string)resultNaturalTeens);
            Assert.AreEqual("thirty ", (string)resultTens);
      

            
        }

    }
}
