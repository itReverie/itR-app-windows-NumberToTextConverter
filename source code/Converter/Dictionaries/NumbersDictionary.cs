using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Reflection;
using System.IO;
using ConverterResources;

namespace Converter
{
    /// <summary>
    /// Numbers in English
    /// </summary>
    static class NumbersDictionary
    {
        #region Members
        /// <summary>
        /// Resource Manager to localize the numbers according to the culture
        /// </summary>
        private static ResourceManager ResourceManagerNumbers { get;  set; }
        /// <summary>
        /// Culture to localize numbers and text.
        /// </summary>
        private static CultureInfo CultureInfoNumbers { get;  set; }
        #endregion

        #region Properties
        /// <summary>
        /// Natural numbers from 0-9
        /// </summary>
        public static Dictionary<int, string> NaturalTeenNumbers { get; private set; }
        /// <summary>
        /// Ten numbers from 20-90
        /// </summary>
        public static Dictionary<int, string> TenNumbers { get; private set; }
        /// <summary>
        /// Scale numbers, having octillion as maximum based in the decimal value (28-29 significant digits).
        /// </summary>
        public static List<string> ScaleNumbers { get; private set; }
        /// <summary>
        /// String that represents the dot, separator between integers and decimals  
        /// </summary>
        public static string And { get; private set; }
        /// <summary>
        /// String that represents the symbol -, for negative numbers  
        /// </summary>
        public static string Minus { get; private set; }
        /// <summary>
        /// String for dollars 
        /// </summary>
        public static string Dollars { get; private set; }
        /// <summary>
        /// String for cents 
        /// </summary>
        public static string Cents { get; private set; }
        #endregion
        
        #region Methods
        /// <summary>
        /// Loads naturals, teens, tens and scale numbers in English.
        /// </summary>
        public static void LoadNumbers(CultureInfo culture)
        {
            CultureInfoNumbers = culture;
            ResourceManagerNumbers = new ResourceManager("ConverterResources.Numbers", typeof(Numbers).Assembly);
            And = GetResourceString("and");
            Minus = GetResourceString("minus");
            Dollars = GetResourceString("dollars");
            Cents = GetResourceString("cents");
            LoadNaturals();
            LoadTeens();
            LoadTens();
            LoadScales();
        }

        /// <summary>
        /// Creates the collection of natural numbers from 0-9 and its corresponding text.
        /// </summary>
        private static void LoadNaturals()
        {
            NaturalTeenNumbers = new Dictionary<int, string>();
            NaturalTeenNumbers.Add(0, GetResourceString("zero "));
            NaturalTeenNumbers.Add(1, GetResourceString("one"));
            NaturalTeenNumbers.Add(2, GetResourceString("two"));
            NaturalTeenNumbers.Add(3, GetResourceString("three"));
            NaturalTeenNumbers.Add(4, GetResourceString("four"));
            NaturalTeenNumbers.Add(5, GetResourceString("five"));
            NaturalTeenNumbers.Add(6, GetResourceString("six"));
            NaturalTeenNumbers.Add(7, GetResourceString("seven"));
            NaturalTeenNumbers.Add(8, GetResourceString("eight"));
            NaturalTeenNumbers.Add(9, GetResourceString("nine"));
        }

        /// <summary>
        /// Creates the collection of teen numbers from 10-19 and its corresponding text.
        /// </summary>
        private static void LoadTeens()
        {
            NaturalTeenNumbers.Add(10, GetResourceString("ten"));
            NaturalTeenNumbers.Add(11, GetResourceString("eleven"));
            NaturalTeenNumbers.Add(12, GetResourceString("twelve"));
            NaturalTeenNumbers.Add(13, GetResourceString("thirteen"));
            NaturalTeenNumbers.Add(14, GetResourceString("fourteen"));
            NaturalTeenNumbers.Add(15, GetResourceString("fifteen"));
            NaturalTeenNumbers.Add(16, GetResourceString("sixteen"));
            NaturalTeenNumbers.Add(17, GetResourceString("seventeen"));
            NaturalTeenNumbers.Add(18, GetResourceString("eighteen"));
            NaturalTeenNumbers.Add(19, GetResourceString("nineteen"));
        }

        /// <summary>
        /// Creates the collection of ten numbers from 20-90 and its corresponding text.
        /// </summary>
        private static void LoadTens()
        {
            TenNumbers = new Dictionary<int, string>();
            TenNumbers.Add(2, GetResourceString("twenty"));
            TenNumbers.Add(3, GetResourceString("thirty"));
            TenNumbers.Add(4, GetResourceString("forty"));
            TenNumbers.Add(5, GetResourceString("fifty"));
            TenNumbers.Add(6, GetResourceString("sixty"));
            TenNumbers.Add(7, GetResourceString("seventy"));
            TenNumbers.Add(8, GetResourceString("eighty"));
            TenNumbers.Add(9, GetResourceString("ninety"));
            TenNumbers.Add(10, GetResourceString("hundred"));
        }

        /// <summary>
        /// Creates a list of the scales for a maximum number of  type decimal
        /// </summary>
        /// <remarks>
        /// The max value for decimal -> 16 bytes (28 significant digits)
        /// For the purpose of this excercise we are considering octillion(Math.Pow(10,27)) as maximum.
        /// </remarks>
        /// <see cref="http://en.wikipedia.org/wiki/Names_of_large_numbers"/>
        private static void LoadScales()
        {
            ScaleNumbers = new List<string>();
            ScaleNumbers.Add("");
            ScaleNumbers.Add(GetResourceString("thousand"));
            ScaleNumbers.Add(GetResourceString("million"));
            ScaleNumbers.Add(GetResourceString("billion"));
            ScaleNumbers.Add(GetResourceString("trillion"));
            ScaleNumbers.Add(GetResourceString("quadrillion"));
            ScaleNumbers.Add(GetResourceString("quintillion"));
            ScaleNumbers.Add(GetResourceString("sextillion"));
            ScaleNumbers.Add(GetResourceString("septillion"));
            ScaleNumbers.Add(GetResourceString("octillion"));
        }

        /// <summary>
        /// Gets the correct strings from the resource files based on the culture
        /// </summary>
        /// <param name="number">Name of the key for the number to get the text.</param>
        /// <returns>Text for the corresponding number according to the culture.</returns>
        private static string GetResourceString(string number)
        {
            return ResourceManagerNumbers.GetString(number, CultureInfoNumbers);
        }
        #endregion
    }
}
