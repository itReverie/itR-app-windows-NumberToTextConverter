using System;
using System.Collections.Generic;
using System.IO;
using ConverterUnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    /// <summary>
    /// Test Class for the decimal values on the converter program
    /// </summary>
    [TestClass]
    public class NumberToText_Decimals
    {
        #region TestContextRegion
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext{
            get{return testContextInstance;}
            set{testContextInstance = value;}
        }
        #endregion

        #region TestingRanges
        /// <summary>
        /// Test invalid ranges of values.
        /// </summary>
        /// <remarks>The main focus of this test is to exceed the ranges allowed</remarks>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestData\\DecimalsRangeData.xml",
            "InvalidRanges",
            DataAccessMethod.Sequential)]
        public void DecimalsInvalidRangeValues()
        {
            string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
            NumberTester numberClass = new NumberTester();
            string actual_value = numberClass.ToText(numberInput);
        }
        /// <summary>
        /// Test valid ranges of values.
        /// </summary>
        /// <remarks>The maximum and minimum values are based on the decimal type -> 16 bytes (28 significant digits)
        /// For the purpose of this excercise we are considering octillion(Math.Pow(10,27)) as maximum.</remarks>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "|DataDirectory|\\TestData\\DecimalsRangeData.xml",
                    "ValidRanges",
                    DataAccessMethod.Sequential)]
        public void DecimalsValidRangeValues()
        {
            try
            {
                string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
                string numberOutput = Convert.ToString(TestContext.DataRow["Text"]);
                NumberTester numberClass = new NumberTester();
                string actual_value = numberClass.ToText(numberInput);
                Assert.AreEqual(numberOutput, actual_value);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region TestingInputs
        /// <summary>
        /// Test some possible combinations of invalid inputs. 
        /// </summary>
        /// <remarks>Incorrect values like: special characters, symbols and incorrect formats.</remarks>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "|DataDirectory|\\TestData\\DecimalsInputData.xml",
                    "InvalidInputs",
                    DataAccessMethod.Sequential)]
        public void DecimalsIncorrectInputs()
        {
            string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
            NumberTester numberClass = new NumberTester();
            string actual_value = numberClass.ToText(numberInput);
        }
        /// <summary>
        /// Test some possible combinations of valid inputs.
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "|DataDirectory|\\TestData\\DecimalsInputData.xml",
                    "ValidInputs",
                    DataAccessMethod.Sequential)]
        public void DecimalsCorrectInputs()
        {
            try
            {
                string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
                string numberOutput = Convert.ToString(TestContext.DataRow["Text"]);
                NumberTester numberClass = new NumberTester();
                string actual_value = numberClass.ToText(numberInput);
                Assert.AreEqual(numberOutput, actual_value);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region TestingValues
        /// <summary>
        /// Testing that the text corresponding to the input number is the correct one.
        /// </summary>
        /// <remarks>The main focus is the corect generation of scales.(million, billion,etc.)</remarks>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "|DataDirectory|\\TestData\\DecimalsValidData.xml",
                    "ValidDecimalValues",
                    DataAccessMethod.Sequential)]
        public void DecimalsTestingRandomValues()
        {
            try
            {
                string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
                string numberOutput = Convert.ToString(TestContext.DataRow["Text"]);
                NumberTester numberClass = new NumberTester();
                string actual_value = numberClass.ToText(numberInput);
                Assert.AreEqual(numberOutput, actual_value);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Testing that the text corresponding to the input number is the correct one.
        /// </summary>
        /// <remarks>Based on the logic of sets of three, the validation of the correct position to determine the value of the important is relevant.</remarks>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestData\\DecimalsValidData.xml",
            "ValidDecimalValues",
            DataAccessMethod.Sequential)]
        public void DecimalsTestingZeroValues()
        {
            try
            {
                string numberInput = Convert.ToString(TestContext.DataRow["Number"]);
                string numberOutput = Convert.ToString(TestContext.DataRow["Text"]);
                NumberTester numberClass = new NumberTester();
                string actual_value = numberClass.ToText(numberInput);
                Assert.AreEqual(numberOutput, actual_value);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion
    }
}
