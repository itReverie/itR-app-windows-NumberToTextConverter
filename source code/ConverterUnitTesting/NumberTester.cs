using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Converter;

namespace ConverterUnitTesting
{
    /// <summary>
    /// Facade to call the static method on the Converter application in order to do the testing
    /// </summary>
    public class NumberTester
    {
        /// <summary>
        /// Facade method to call the static method on the Converter application in order to do the testing
        /// </summary>
        /// <param name="number">Number to be converted into text.</param>
        /// <returns>Number in text format.</returns>
        public string ToText(string number)
        {
            return Number.ToText(number);
        }

        /// <summary>
        /// Facade method to call the static method on the Converter application in order to do the testing
        /// </summary>
        /// <param name="number">Number to be converted into text.</param>
        /// <returns>Number in text format.</returns>
        public string ToText(string number, CultureInfo culture)
        {
            return Number.ToText(number, culture);
        }
    }
}
