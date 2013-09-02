using System;
using System.Collections.Generic;
using System.IO;
using ConverterController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    /// <summary>
    /// Test Class for the integer values on the converter program
    /// </summary>
    [TestClass]
    public class NumberToText_Integers
    {
        #region TestingRanges
        /// <summary>
        /// Test valid ranges of values.
        /// </summary>
        /// <remarks>The maximum and minimum values are based on the decimal type -> 16 bytes (28 significant digits)
        /// For the purpose of this excercise we are considering octillion(Math.Pow(10,27)) as maximum.</remarks>
        [TestMethod]
        public void ValidRangeValues()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionRanges = TestingData.GetCollectionRanges();
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
        public void InvalidRangeValues()
        {
         try{   
                Number numberClass = new Number();
                List<string> listRangesOutOfBoundaries = TestingData.GetListRangesOutOfBoundaries();
                foreach (string incorrectInput in listRangesOutOfBoundaries)
                {
                    try{
                        string actual_value = numberClass.TestCallToText(incorrectInput);
                    }catch (Exception ex){
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
        public void CorrectInputs()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionCorrectInputs = TestingData.GetCollectionCorrectInputs();
                foreach (KeyValuePair<string,string> correctInput in collectionCorrectInputs)
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
        public void IncorrectInputs()
        {
            try
            {
                Number numberClass = new Number();
                List<string> listIncorrectInputs = TestingData.GetListIncorrectInputs();
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
        public void TestingRandomValues()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionRandomValues = TestingData.GetCollectionRandomValues();
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
        public void TestingZeroValuesOnIntegers()
        {
            try
            {
                Number numberClass = new Number();
                Dictionary<string, string> collectionZeroValues = TestingData.GetCollectionZeroValues();
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
