using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace ConverterController
{
    public static class EnglishErrorMessages
    {
        /// <summary>
        /// Error in the input value
        /// </summary>
        public static string Error_InvalidInput = "The following input is invalid.";

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_OnlyNumericDigits = "The program only accepts numbers.";

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_IncorrectFormat = "The number is in an incorrect format.";

        /// <summary>
        /// The number is not in a valid range 
        /// </summary>
        public static string Reason_IntegerOutOfBoundaries = "The program accepts positive and negative values with a maximum of 28 positions as integer and 3 decimals.";

        /// <summary>
        /// The decimals are not in a valid range 
        /// </summary>
        public static string Reason_DecimalOutOfBoundaries = "The program accepts a maximum of two decimals.";

    }
}
