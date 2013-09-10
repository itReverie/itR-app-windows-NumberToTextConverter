using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Converter;

namespace Converter
{
    /// <summary>
    /// Derived class from NumberBase to convert decimal numbers to English text
    /// </summary>
    class NumberSpanish : NumberBase
    {
        /// <summary>
        /// Constructor to load Spanish resources.
        /// </summary>
        /// <param name="culture"></param>
        public NumberSpanish(CultureInfo culture)
        {
            NumbersDictionary.LoadNumbers(culture);
            ErrorMessagesDictionary.LoadErrorsText(culture);
        }

        /// <summary>
        /// Iterates a set of three numbers representing Hundreds-Tens-Naturals
        /// </summary>
        /// <param name="position">Position of the number</param>
        /// <param name="number">Number</param>
        /// <param name="outputText">Number in text format.</param>
        /// <returns>Number in text format.</returns>
        /// <remarks>This particular method should be edited to contactenate some strings to make the spanish numbers correct.
        /// </remarks>
        protected override string IterationOfNumbers(int position, decimal number, string outputText)
        {
            decimal nextNumber = 0;
            //Validation for 0
            if (number == 0 && outputText.Length > 0)
            {
                return outputText;
            }
            switch (ValidateNumberPosition(position, number))
            {
                case 1: //Number from 0-9
                    outputText += NumberToText(number, NumbersDictionary.NaturalTeenNumbers);
                    return outputText;
                case 2: //Number from 10-99
                    if (number < 20)
                    {
                        //Number from 10-19
                        outputText += NumberToText(number, NumbersDictionary.NaturalTeenNumbers);
                        return outputText;
                    }
                    else
                    {
                        //Number from 20-99
                        outputText += NumberToText((number / 10), NumbersDictionary.TenNumbers);
                        nextNumber = number % 10;
                        return IterationOfNumbers(position - 1, nextNumber, outputText);
                    }
                case 3://Number from 100-999
                    if (number >= 100)
                    {
                        outputText += NumberToText(number / 100, NumbersDictionary.NaturalTeenNumbers).Trim() + NumberToText(10, NumbersDictionary.TenNumbers);
                        nextNumber = number % 100;
                    }
                    else
                    {
                        nextNumber = number;
                    }
                    return IterationOfNumbers(position - 1, nextNumber, outputText);
                default:
                    return outputText;
            }
            return outputText;
        }
    }
}
