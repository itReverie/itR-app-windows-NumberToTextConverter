using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Converter;

namespace Converter
{
    /// <summary>
    /// Converts numbers into its corresponding text. 
    /// </summary>
    /// <example>Converts 125.25 in one hundred twenty five dollars and twenty five cents </example>
    public class Number 
    {
        #region PublicMethods
        /// <summary>
        /// Converts any number including decimals into the correpsonding text.
        /// </summary>
        /// <param name="inputNumber">Any positive adn negative number including decimals.</param>
        /// <returns>The corresponding text for the input number.</returns>
        /// <remarks>The culture by default is English</remarks>
        public static string ToText(string inputNumber)
        {
            string outputText = string.Empty;
            NumberBase number = new NumberEnglish(new CultureInfo("es-US"));
            return number.ToText(inputNumber);
        }

        /// <summary>
        /// Converts any number including decimals into the correpsonding text.
        /// </summary>
        /// <param name="inputNumber">Any positive and negative number including decimals.</param>
        /// <param name="culture">Culture to localize the numbers.</param>
        /// <returns>The corresponding text for the input number.</returns>
        public static string ToText(string inputNumber, CultureInfo culture)
        {
            NumberBase number = null;
            switch (culture.Name)
            {
                case "es-MX":
                    number = new NumberSpanish(new CultureInfo("es-MX"));
                    break;
                case "fr-FR":
                    //number = new NumberFrench(new CultureInfo("fr-FR"));
                    break;
                default:
                    number = new NumberEnglish(new CultureInfo("es-US"));
                    break;
            }
            return number.ToText(inputNumber);
        }
        #endregion



       
    }
}
