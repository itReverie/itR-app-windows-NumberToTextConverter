using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterUnitTesting
{
    /// <summary>
    /// Class that contains the data to test different scenarios in the unit testing
    /// </summary>
    public static class TestingData
    {
        #region Data_To_TestRanges
        /// <summary>
        /// Collection of values within the range of a decimal type
        /// </summary>
        public static Dictionary<string, string> GetCollectionRanges()
        {
            Dictionary<string, string> listScalesNumbers = new Dictionary<string, string>();
            listScalesNumbers.Add("1.0", "one dollars and zero cents");
            listScalesNumbers.Add("10.0", "ten dollars and zero cents");
            listScalesNumbers.Add("100.0", "one hundred dollars and zero cents");
            listScalesNumbers.Add("1000.0", "one thousand dollars and zero cents");
            listScalesNumbers.Add("10000.0", "ten thousand dollars and zero cents");
            listScalesNumbers.Add("100000.0", "one hundred thousand dollars and zero cents");
            listScalesNumbers.Add("1000000.0", "one million dollars and zero cents");
            listScalesNumbers.Add("10000000.0", "ten million dollars and zero cents");
            listScalesNumbers.Add("100000000.0", "one hundred million dollars and zero cents");
            listScalesNumbers.Add("1000000000.0", "one billion dollars and zero cents");
            listScalesNumbers.Add("10000000000.0", "ten billion dollars and zero cents");
            listScalesNumbers.Add("100000000000.0", "one hundred billion dollars and zero cents");
            listScalesNumbers.Add("1000000000000.0", "one trillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000.0", "ten trillion dollars and zero cents");
            listScalesNumbers.Add("100000000000000.0", "one hundred trillion dollars and zero cents");
            listScalesNumbers.Add("1000000000000000.0", "one quadrillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000000.0", "ten quadrillion dollars and zero cents");
            listScalesNumbers.Add("100000000000000000.0", "one hundred quadrillion dollars and zero cents");
            listScalesNumbers.Add("1000000000000000000.0", "one quintillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000000000.0", "ten quintillion dollars and zero cents");
            listScalesNumbers.Add("100000000000000000000.0", "one hundred quintillion dollars and zero cents");
            listScalesNumbers.Add("1000000000000000000000.0", "one sextillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000000000000.0", "ten sextillion dollars and zero cents");
            listScalesNumbers.Add("100000000000000000000000.0", "one hundred sextillion dollars and zero cents");
            listScalesNumbers.Add("1000000000000000000000000.0", "one septillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000000000000000.0", "ten septillion dollars and zero cents");
            listScalesNumbers.Add("100000000000000000000000000.0", "one hundred septillion dollars and zero cents");
            listScalesNumbers.Add("1000000000000000000000000000.0", "one octillion dollars and zero cents");
            listScalesNumbers.Add("10000000000000000000000000000.0", "ten octillion dollars and zero cents");
            return listScalesNumbers;
        }

        /// <summary>
        /// Collection of values out of the boundaries of a decimal type
        /// </summary>
        /// <returns></returns>
        public static List<string> GetListRangesOutOfBoundaries()
        {
            List<string> listScalesOutOfBoundaries = new List<string>();
            listScalesOutOfBoundaries.Add("99999999999999999999999999999.0");
            listScalesOutOfBoundaries.Add("-99999999999999999999999999999.0");
            listScalesOutOfBoundaries.Add("123.45e+6");
            return listScalesOutOfBoundaries;
        }
        #endregion

        #region Data_To_TestInputs
        /// <summary>
        /// Collection of incorrect input values
        /// </summary>
        public static List<string> GetListIncorrectInputs()
        {
            List<string> listIncorrectInputs = new List<string>();
            listIncorrectInputs.Add("");
            listIncorrectInputs.Add(".");
            listIncorrectInputs.Add("asadsf");
            listIncorrectInputs.Add("/*-");
            listIncorrectInputs.Add("+36.98");
            listIncorrectInputs.Add("+895.36");
            listIncorrectInputs.Add("895.+36");
            listIncorrectInputs.Add("895.-36");
            listIncorrectInputs.Add("15.96.48");
            listIncorrectInputs.Add("مرحبا!");
            listIncorrectInputs.Add("指事字");
            listIncorrectInputs.Add("-1E-16");
            listIncorrectInputs.Add("-10d");
            return listIncorrectInputs;
        }

        /// <summary>
        /// Collection of correct input values
        /// </summary>
        public static Dictionary<string, string> GetCollectionCorrectInputs()
        {
            Dictionary<string, string> collectionCorrectInputs = new Dictionary<string, string>();
            collectionCorrectInputs.Add("1.0", "one dollars and zero cents");
            collectionCorrectInputs.Add("0", "zero dollars and zero cents");
            collectionCorrectInputs.Add(".0", "zero dollars and zero cents");
            collectionCorrectInputs.Add("0.", "zero dollars and zero cents");
            collectionCorrectInputs.Add("0.0", "zero dollars and zero cents");
            collectionCorrectInputs.Add("1025.63", "one thousand twenty five dollars and sixty three cents");
            collectionCorrectInputs.Add("-1025.63", "minus one thousand twenty five dollars and sixty three cents");
            return collectionCorrectInputs;
        }
        #endregion

        #region Data_To_TestRandomValues
        /// <summary>
        /// Collection of some correct random values
        /// </summary>
        public static Dictionary<string, string> GetCollectionRandomValues()
        {
            Dictionary<string, string> collectionRandomValues = new Dictionary<string, string>();
            collectionRandomValues.Add("9.0", "nine dollars and zero cents");
            collectionRandomValues.Add("990.0", "nine hundred ninety dollars and zero cents");
            collectionRandomValues.Add("9090.0", "nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("90909.0", "ninety thousand nine hundred nine dollars and zero cents");
            collectionRandomValues.Add("909090.0", "nine hundred nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("9090909.0", "nine million ninety thousand nine hundred nine dollars and zero cents");
            collectionRandomValues.Add("90909090.0", "ninety million nine hundred nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("909090909.0", "nine hundred nine million ninety thousand nine hundred nine dollars and zero cents");
            collectionRandomValues.Add("9090909090.0", "nine billion ninety million nine hundred nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("90909090909.0", "ninety billion nine hundred nine million ninety thousand nine hundred nine dollars and zero cents");
            collectionRandomValues.Add("909090909090.0", "nine hundred nine billion ninety million nine hundred nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("9090909090909.0", "nine trillion ninety billion nine hundred nine million ninety thousand nine hundred nine dollars and zero cents");
            collectionRandomValues.Add("90909090909090.0", "ninety trillion nine hundred nine billion ninety million nine hundred nine thousand ninety dollars and zero cents");
            collectionRandomValues.Add("9909090909090909090909090909.0", "nine octillion nine hundred nine septillion ninety sextillion nine hundred nine quintillion ninety quadrillion nine hundred nine trillion ninety billion nine hundred nine million ninety thousand nine hundred nine dollars and zero cents");
            return collectionRandomValues;
        }

        /// <summary>
        /// Collection of some correct random values with zeros 
        /// </summary>
        public static Dictionary<string, string> GetCollectionZeroValues()
        {
            Dictionary<string, string> collectionZeroValues = new Dictionary<string, string>();
            collectionZeroValues.Add("0", "zero dollars and zero cents");
            collectionZeroValues.Add("00.0", "zero dollars and zero cents");
            collectionZeroValues.Add("02.0", "two dollars and zero cents");
            collectionZeroValues.Add("000.0", "zero dollars and zero cents");
            collectionZeroValues.Add("000000.0", "zero dollars and zero cents");
            collectionZeroValues.Add("0000000000.0", "zero dollars and zero cents");
            collectionZeroValues.Add("101.0", "one hundred one dollars and zero cents");
            collectionZeroValues.Add("1001.0", "one thousand one dollars and zero cents");
            collectionZeroValues.Add("10000000000001.0", "ten trillion one dollars and zero cents");
            collectionZeroValues.Add("10000000000000000000000000001.0", "ten octillion one dollars and zero cents"); 
            return collectionZeroValues;
        }
        #endregion
    }
}
