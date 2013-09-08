using System;
using ConverterUnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterUnitTesting
{
    /// <summary>
    /// Test Class to evaluate the performance of the program.
    /// </summary>
    [TestClass]
    public class NumberToText_Performance
    {
        /// <summary>
        /// Testing the performance of the application based on a generation of random numbers.
        /// </summary>
        [TestMethod]
        public void TestingPerformance()
        {
            try
            {
                string resultPath = "ConverterPerformanceResults.txt";
                NumberTester numberTester = new NumberTester();
                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(resultPath))
                {
                    DecimalRandom decimalRandom = new DecimalRandom();
                    for (int i = 0; i <= 10000; i++)
                    {
                        decimal randomNumber = decimalRandom.NextDecimal();
                        string randomDecimal = Convert.ToString(randomNumber);
                        string randomDecimalInText = numberTester.ToText(Convert.ToString(randomNumber));
                        streamWriter.WriteLine(randomDecimal + "\t\t\t" + randomDecimalInText);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Performace test error.");
            }
        }
    }

    /// <summary>
    /// Class to generate random decimals 
    /// </summary>
    /// <remarks>This function was extracted from the following link and it was modified to cover my needs. </remarks>
    /// <see cref="http://stackoverflow.com/questions/609501/generating-a-random-decimal-in-c-sharp"/>
    public class DecimalRandom : Random
    {
        public decimal NextDecimal()
        {
            //The low 32 bits of a 96-bit integer. 
            int lo = this.Next(int.MinValue, int.MaxValue);
            //The middle 32 bits of a 96-bit integer. 
            int mid = this.Next(int.MinValue, int.MaxValue);
            //The high 32 bits of a 96-bit integer. 
            int hi = this.Next(int.MinValue, int.MaxValue);
            //The sign of the number; 1 is negative, 0 is positive. 
            bool isNegative = (this.Next(2) == 0);
            //A power of 10 ranging from 0 to 28. 
            byte scale = Convert.ToByte(this.Next(29));
            Decimal randomDecimal = new Decimal(lo, mid, hi, isNegative, scale);

            //Setting the number to 2 decimals
            string decimalText =randomDecimal.ToString("#.##");
            decimal truncatedDecimal = 0;
            Decimal.TryParse(decimalText, out truncatedDecimal);
            return truncatedDecimal;
        }
    }
}
