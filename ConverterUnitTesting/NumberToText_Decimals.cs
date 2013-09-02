using System;
using System.IO;
using ConverterController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    [TestClass]
    public class NumberToText_Decimals
    {
        #region TestingInputs
        [TestMethod]
        public void CorrectInputs()
        {
            try
            {
                EnglishDictionary.LoadNumbers();

                Number numberClass = new Number();
                string actual_correctInput1 = numberClass.TestCallToText("0");
                string actual_correctInput2 = numberClass.TestCallToText("0.0");
                string actual_correctInput3 = numberClass.TestCallToText(".0");
                string actual_correctInput4 = numberClass.TestCallToText("0.");
                string actual_correctInput5 = numberClass.TestCallToText("1025.63");
                string actual_correctInput6 = numberClass.TestCallToText("-1025.63");

                Assert.AreEqual("zero ", actual_correctInput1);
                Assert.AreEqual("zero and zero ", actual_correctInput2);
                Assert.AreEqual("zero and zero ", actual_correctInput3);
                Assert.AreEqual("zero and zero ", actual_correctInput4);
                Assert.AreEqual("one hundred twenty five and sixty three ", actual_correctInput5);
                Assert.AreEqual("minus one hundred twenty five and sixty three ", actual_correctInput6);

            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is IOException);
            }
        }

        [TestMethod]
        public void IncorrectInputs()
        {
            try
            {
                EnglishDictionary.LoadNumbers();

                Number numberClass = new Number();
                string actual_incorrectInput1 = numberClass.TestCallToText("");
                string actual_incorrectInput2 = numberClass.TestCallToText(".");
                string actual_incorrectInput3 = numberClass.TestCallToText("asadsf");
                string actual_incorrectInput4 = numberClass.TestCallToText("/*-");
                string actual_incorrectInput5 = numberClass.TestCallToText("+36.98");
                string actual_incorrectInput6 = numberClass.TestCallToText("+895.36");
                string actual_incorrectInput7 = numberClass.TestCallToText("895.+36");
                string actual_incorrectInput8 = numberClass.TestCallToText("مرحبا!");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is IOException);
            }
        }
        #endregion

        #region TestingMaximumMinimums
        [TestMethod]
        public void MinimumMaximumValues()
        {
            EnglishDictionary.LoadNumbers();
           // 99999999999999999999999999999
            Number numberClass = new Number();
            //TODO: Depending on the decimal answer add the minimums
            //0.1 - valid decimal
            //1.1 - valid decimal
            //1.11 - valid decimal (double digit)
            //1.111 - valid decimal (round down)
            //1.118 (valid decimal round up)
        }

        #endregion

        #region TestingValues
        [TestMethod]
        public void TestingRandomValues()
        {
            EnglishDictionary.LoadNumbers();

            Number numberClass = new Number();
            string actual_0zeros = numberClass.TestCallToText("0.5");
            string actual_1zeros = numberClass.TestCallToText("0.05");
            string actual_2zeros = numberClass.TestCallToText("0.50");


            Assert.AreEqual("nine and zero", actual_0zeros);
            Assert.AreEqual("nine hundred ninety and zero", actual_1zeros);
            Assert.AreEqual("nine thousand ninety and zero", actual_2zeros);

        }
        #endregion

        #region TestingZeroValues
        [TestMethod]
        public void ZeroValuesOnDecimals()
        {
            EnglishDictionary.LoadNumbers();

            Number numberClass = new Number();
            string actual_0zeros = numberClass.TestCallToText(".0");
            string actual_1zeros = numberClass.TestCallToText("0.0");
            string actual_2zeros = numberClass.TestCallToText("0.00");
            string actual_3zeros = numberClass.TestCallToText("0.000");
            string actual_4zeros = numberClass.TestCallToText("0.0000");

            Assert.AreEqual("zero and zero", actual_0zeros);
            Assert.AreEqual("zero and zero", actual_1zeros);
            Assert.AreEqual("zero and zero", actual_2zeros);
            Assert.AreEqual("zero and zero", actual_3zeros);
            Assert.AreEqual("zero and zero", actual_4zeros);
        }

        [TestMethod]
        public void ZeroValuesAmongDecimalSets()
        {
            EnglishDictionary.LoadNumbers();

            Number numberClass = new Number();
            string actual_1zeros = numberClass.TestCallToText("101.0");
            Assert.AreEqual("one hundred one and zero", actual_1zeros);

        }
        #endregion
    }
}
