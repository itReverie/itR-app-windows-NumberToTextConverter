using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using System.IO;
using ConverterResources;
using System.Globalization;

namespace Converter
{
    static class ErrorMessagesDictionary
    {
        #region Members
        /// <summary>
        /// Resource Manager to localize the numbers according to the culture
        /// </summary>
        private static ResourceManager ResourceManagerErrorMessages { get; set; }
        /// <summary>
        /// Culture to localize numbers and text.
        /// </summary>
        private static CultureInfo CultureInfoErrorMessages { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Error in the input value
        /// </summary>
        public static string Error_InvalidInput { get; private set; }

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_OnlyNumericDigits { get; private set; }

        /// <summary>
        /// Sytem only accepts numbers
        /// </summary>
        public static string Reason_IncorrectFormat { get; private set; }

        /// <summary>
        /// The number is not in a valid range 
        /// </summary>
        public static string Reason_IntegerOutOfBoundaries { get; private set; }

        /// <summary>
        /// The decimals are not in a valid range 
        /// </summary>
        public static string Reason_DecimalOutOfBoundaries { get; private set; }
        #endregion

        #region Methods

        /// <summary>
        /// Loads naturals, teens, tens and scale numbers in English.
        /// </summary>
        public static void LoadErrorsText(CultureInfo culture)
        {
            CultureInfoErrorMessages = culture;
            ResourceManagerErrorMessages = new ResourceManager("ConverterResources.Errors", typeof(Errors).Assembly);
            Error_InvalidInput = GetResourceString("InvalidInput");
            Reason_OnlyNumericDigits = GetResourceString("OnlyNumericDigits");
            Reason_IncorrectFormat = GetResourceString("IncorrectFormat");
            Reason_IntegerOutOfBoundaries = GetResourceString("IntegerOutOfBoundaries");
            Reason_DecimalOutOfBoundaries = GetResourceString("DecimalOutOfBoundaries");
        }

        /// <summary>
        /// Gets the correct strings from the resource files based on the culture
        /// </summary>
        /// <param name="keyString">Name of the key to get the text.</param>
        /// <returns>Text for the corresponding key according to the culture.</returns>
        private static string GetResourceString(string keyString)
        {
            return ResourceManagerErrorMessages.GetString(keyString, CultureInfoErrorMessages);
        }
        #endregion
    }
}
