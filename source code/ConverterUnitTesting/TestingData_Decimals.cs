using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConverter
{
    /// <summary>
    /// Class that contains the data to test different scenarios in the unit testing
    /// </summary>
    public static class TestingData_Decimals
    {
        #region Data_To_TestRanges
        /// <summary>
        /// Collection of values within the range of a decimal type
        /// </summary>
        public static Dictionary<string, string> GetCollectionRangesDecimals()
        {
            Dictionary<string, string> listScalesNumbers = new Dictionary<string, string>();
            listScalesNumbers.Add("0", "zero dollars and zero cents");
            listScalesNumbers.Add("0.", "zero dollars and zero cents");
            listScalesNumbers.Add(".0", "zero dollars and zero cents");
            listScalesNumbers.Add("0.0", "zero dollars and zero cents");
            listScalesNumbers.Add("0.00", "zero dollars and zero cents");
            listScalesNumbers.Add("0.99", "zero dollars and ninety nine cents");
            return listScalesNumbers;
        }

        /// <summary>
        /// Collection of values out of the boundaries of a decimal type
        /// </summary>
        /// <returns></returns>
        public static List<string> GetListRangesOutOfBoundariesDecimals()
        {
            List<string> listScalesOutOfBoundaries = new List<string>();
            listScalesOutOfBoundaries.Add("0.000");
            listScalesOutOfBoundaries.Add("0.999");
            return listScalesOutOfBoundaries;
        }
        #endregion

        #region Data_To_TestInputs
        /// <summary>
        /// Collection of incorrect input values
        /// </summary>
        public static List<string> GetListIncorrectInputsDecimals()
        {
            List<string> listIncorrectInputs = new List<string>();
            listIncorrectInputs.Add(".");
            listIncorrectInputs.Add("0.asadsf");
            listIncorrectInputs.Add("0./*");
            listIncorrectInputs.Add("0.+9");
            listIncorrectInputs.Add("895.-3");
            listIncorrectInputs.Add("15.96.48");
            listIncorrectInputs.Add("0.مرحبا!");
            listIncorrectInputs.Add("0.指事字");
            return listIncorrectInputs;
        }

        /// <summary>
        /// Collection of correct input values
        /// </summary>
        public static Dictionary<string, string> GetCollectionCorrectInputsDecimals()
        {
            Dictionary<string, string> collectionCorrectInputs = new Dictionary<string, string>();
            collectionCorrectInputs.Add("1.0", "one dollars and zero cents");
            collectionCorrectInputs.Add("0", "zero dollars and zero cents");
            collectionCorrectInputs.Add(".0", "zero dollars and zero cents");
            collectionCorrectInputs.Add("0.", "zero dollars and zero cents");
            collectionCorrectInputs.Add("0.5", "zero dollars and fifty cents");
            collectionCorrectInputs.Add("0.50", "zero dollars and fifty cents");
            collectionCorrectInputs.Add("0.05", "zero dollars and five cents");
            return collectionCorrectInputs;
        }
        #endregion

        #region Data_To_TestRandomValues
        /// <summary>
        /// Collection of some correct random values
        /// </summary>
        public static Dictionary<string, string> GetCollectionRandomValuesDecimals()
        {
            Dictionary<string, string> collectionRandomValues = new Dictionary<string, string>();
            collectionRandomValues.Add("0.9", "zero dollars and ninety cents");
            collectionRandomValues.Add("0.09", "zero dollars and nine cents");
            collectionRandomValues.Add("0.23", "zero dollars and twenty three cents");
            collectionRandomValues.Add("0.03", "zero dollars and three cents");
            collectionRandomValues.Add("0.55", "zero dollars and fifty five cents");
            return collectionRandomValues;
        }

        /// <summary>
        /// Collection of some correct random values with integers and decimals  
        /// </summary>
        public static Dictionary<string, string> GetCollectionIntegersDecimals()
        {
            Dictionary<string, string> collectionZeroValues = new Dictionary<string, string>();
            collectionZeroValues.Add("0", "zero dollars and zero cents");
            collectionZeroValues.Add("73.00", "seventy three dollars and zero cents");
            collectionZeroValues.Add("02.08", "two dollars and eight cents");
            collectionZeroValues.Add("80706050403021.14", "eighty trillion seven hundred six billion fifty million four hundred three thousand twenty one dollars and fourteen cents");
            collectionZeroValues.Add("-780000460000054600075470001.58", "minus seven hundred eighty septillion four hundred sixty quintillion fifty four trillion six hundred billion seventy five million four hundred seventy thousand one dollars and fifty eight cents"); 
            return collectionZeroValues;
        }
        #endregion
    }
}
