using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterController
{
    /// <summary>
    /// Numbers in English
    /// </summary>
    public class EnglishDictionary
    {
        #region Properties
        /// <summary>
        /// Natural numbers from 0-9
        /// </summary>
        public static Dictionary<int, string> NaturalTeenNumbers { get; private set; }
        /// <summary>
        /// Teen numbers from 10-19
        /// </summary>
       // public static Dictionary<int, string> TeenNumbers { get; private set; }
        /// <summary>
        /// Ten numbers from 20-90
        /// </summary>
        public static Dictionary<int, string> TenNumbers { get; private set; }
        /// <summary>
        /// Scale numbers, having quadrillion as maximum based in the Int64 value.
        /// </summary>
        public static List<string> ScaleNumbers { get; private set; }
        /// <summary>
        /// String that represents the dot, separator between integers and decimals  
        /// </summary>
        public static string Dot { get; private set; }
        #endregion
        
        #region Methods

        /// <summary>
        /// Loads naturals, teens, tens and scale numbers in English.
        /// </summary>
        public static void LoadNumbers()
        {
            LoadNaturals();
            LoadTeens();
            LoadTens();
            LoadScales();
            Dot = "and ";
        }

        /// <summary>
        /// Creates the collection of natural numbers from 0-9 and its corresponding text.
        /// </summary>
        private static void LoadNaturals()
        {
            NaturalTeenNumbers = new Dictionary<int, string>();
            NaturalTeenNumbers.Add(0, "zero ");
            NaturalTeenNumbers.Add(1, "one ");
            NaturalTeenNumbers.Add(2, "two ");
            NaturalTeenNumbers.Add(3, "three ");
            NaturalTeenNumbers.Add(4, "four ");
            NaturalTeenNumbers.Add(5, "five ");
            NaturalTeenNumbers.Add(6, "six ");
            NaturalTeenNumbers.Add(7, "seven ");
            NaturalTeenNumbers.Add(8, "eight ");
            NaturalTeenNumbers.Add(9, "nine ");
        }

        /// <summary>
        /// Creates the collection of teen numbers from 10-19 and its corresponding text.
        /// </summary>
        private static void LoadTeens()
        {
            NaturalTeenNumbers.Add(10, "ten ");
            NaturalTeenNumbers.Add(11, "eleven ");
            NaturalTeenNumbers.Add(12, "twelve ");
            NaturalTeenNumbers.Add(13, "thirteen ");
            NaturalTeenNumbers.Add(14, "fourteen ");
            NaturalTeenNumbers.Add(15, "fiveteen ");
            NaturalTeenNumbers.Add(16, "sixteen ");
            NaturalTeenNumbers.Add(17, "seventeen ");
            NaturalTeenNumbers.Add(18, "eighteen ");
            NaturalTeenNumbers.Add(19, "nineteen ");
        }

        /// <summary>
        /// Creates the collection of ten numbers from 20-90 and its corresponding text.
        /// </summary>
        private static void LoadTens()
        {
            TenNumbers = new Dictionary<int, string>();
            TenNumbers.Add(2, "twenty ");
            TenNumbers.Add(3, "thirty ");
            TenNumbers.Add(4, "fourty ");
            TenNumbers.Add(5, "fifty ");
            TenNumbers.Add(6, "sixty ");
            TenNumbers.Add(7, "seventy ");
            TenNumbers.Add(8, "eighty ");
            TenNumbers.Add(9, "ninety ");
            TenNumbers.Add(10, "hundred ");
        }

        /// <summary>
        /// Creates a list of the scales for a maximum integer of  type Int64
        /// </summary>
        /// <remarks>
        /// The max value for Int32 -> +- 2 147 483 684
        /// The max value for Int64 -> +- 9 223 372 036 854 775 808
        /// For the purpose of this excercise we are considering trillion(Math.Pow(10,14)) as maximum
        /// </remarks>
        private static void LoadScales()
        {
            ScaleNumbers = new List<string>();
            ScaleNumbers.Add("");
            ScaleNumbers.Add("thousand ");
            ScaleNumbers.Add("million ");
            ScaleNumbers.Add("billion ");
            ScaleNumbers.Add("trillion ");
        }
        #endregion
    }
}
