using System;
using System.Collections.Generic;
using System.IO;
using ConverterController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingConverter
{
    [TestClass]
    public class NumberToText_Decimals
    {

        #region TestingRanges
        /// <summary>
        /// Test valid ranges of values.
        /// </summary>
        /// <remarks>The maximum and minimum values are based on the decimal type -> 16 bytes (28 significant digits)
        /// For the purpose of this excercise we are considering octillion(Math.Pow(10,27)) as maximum.</remarks>
        [TestMethod]
        public void DecimalValidRangeValues()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionRanges = TestingData_Decimals.GetCollectionRangesDecimals();
                foreach (KeyValuePair<string, string> range in collectionRanges)
                {
                    string actual_value = numberClass.TestCallToText(range.Key);
                    Assert.AreEqual(range.Value, actual_value);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test invalid ranges of values.
        /// </summary>
        /// <remarks>The main focus of this test is to exceed the ranges allowed</remarks>
        [TestMethod]
        public void DecimalInvalidRangeValues()
        {
            try
            {
                Number numberClass = new Number();
                List<string> listRangesOutOfBoundaries = TestingData_Decimals.GetListRangesOutOfBoundariesDecimals();
                foreach (string incorrectInput in listRangesOutOfBoundaries)
                {
                    try
                    {
                        string actual_value = numberClass.TestCallToText(incorrectInput);
                    }
                    catch (Exception ex)
                    {
                        Assert.IsTrue(ex is ArgumentOutOfRangeException);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region TestingInputs
        /// <summary>
        /// Test some possible combinations of valid inputs.
        /// </summary>
        [TestMethod]
        public void DecimalCorrectInputs()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionCorrectInputs = TestingData_Decimals.GetCollectionCorrectInputsDecimals();
                foreach (KeyValuePair<string, string> correctInput in collectionCorrectInputs)
                {
                    string actual_value = numberClass.TestCallToText(correctInput.Key);
                    Assert.AreEqual(correctInput.Value, actual_value);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test some possible combinations of invalid inputs. 
        /// </summary>
        /// <remarks>Incorrect values like: special characters, symbols and incorrect formats.</remarks>
        [TestMethod]
        public void DecimalIncorrectInputs()
        {
            try
            {
                Number numberClass = new Number();
                List<string> listIncorrectInputs = TestingData_Decimals.GetListIncorrectInputsDecimals();
                foreach (string incorrectInput in listIncorrectInputs)
                {
                    try
                    {
                        string actual_value = numberClass.TestCallToText(incorrectInput);
                    }
                    catch (Exception ex)
                    {
                        Assert.IsTrue(ex is IOException);
                    }
                }
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
        public void DecimalTestingRandomValues()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionRandomValues = TestingData_Decimals.GetCollectionRandomValuesDecimals();
                foreach (KeyValuePair<string, string> randomValue in collectionRandomValues)
                {
                    string actual_value = numberClass.TestCallToText(randomValue.Key);
                    Assert.AreEqual(randomValue.Value, actual_value);
                }
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
        public void DecimalTestingZeroValues()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionZeroValues = TestingData_Decimals.GetCollectionIntegersDecimals();
                foreach (KeyValuePair<string, string> zeroValue in collectionZeroValues)
                {
                    string actual_value = numberClass.TestCallToText(zeroValue.Key);
                    Assert.AreEqual(zeroValue.Value, actual_value);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion
    }
}
