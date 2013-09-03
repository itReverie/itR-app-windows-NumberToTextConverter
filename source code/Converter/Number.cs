using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConverterController
{
    /// <summary>
    /// Converts numbers into its corresponding text. 
    /// </summary>
    /// <example>Converts 125.25 in one hundred twenty five dollars and twenty five cents </example>
    public class Number
    {
        #region Methods
        /// <summary>
        /// Converts any number including decimals into the correpsonding text.
        /// </summary>
        /// <param name="inputNumber">Any positive number including decimals.</param>
        /// <returns>The corresponding text for the value of the number.</returns>
        public static string ToText(string inputNumber)
        {
            string outputText = string.Empty;
            decimal tryingtoZero = 0;
            Number number = new Number();
            EnglishDictionary.LoadNumbers();
            string moneyValue = EnglishDictionary.Dollars;
            
            //Getting sets of numbers: integers and decimals
            if (inputNumber == ""){
                throw new IOException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_IncorrectFormat);
            }
            List<string> setNumbers = inputNumber.Split(new char[] { '.' }).ToList();
            if (setNumbers.Count > 2 || (setNumbers[0] == "" && setNumbers[1]=="")){
                throw new IOException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_IncorrectFormat);
            }
            //Setting a correct List
            if (setNumbers.Count == 1){
                setNumbers.Add("0");
            }

            for(int i=0; i <setNumbers.Count();i++)
            {
                //Initializing the sets with zero if there is no valid value
                if (setNumbers[i] == "") { setNumbers[i] = "0"; }

                //Validations for the first set: integers
                if (i == 0)
                {
                    if (!Regex.IsMatch(setNumbers[i], "^-[0-9]+$|^[0-9]+$")){
                        throw new IOException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_OnlyNumericDigits);}

                    if (setNumbers[i].StartsWith("-")){
                        setNumbers[i] = setNumbers[i].Remove(0, 1);
                        outputText = EnglishDictionary.Minus;
                    }else if (setNumbers[i].StartsWith("+")){
                        setNumbers[i] = setNumbers[i].Remove(0, 1);}
                }

                //Validations for the second set : decimals
                else if (i == 1){
                    if (!Regex.IsMatch(setNumbers[i], "^[0-9]+$")){
                        throw new IOException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_OnlyNumericDigits);}
                    if (setNumbers[i].Length > 2){
                        throw new ArgumentOutOfRangeException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_DecimalOutOfBoundaries);}

                    outputText += moneyValue + EnglishDictionary.And;
                    moneyValue = EnglishDictionary.Cents;
                    //Filling in the set with 000 to the right just for a max of two decimals
                    if (setNumbers[i].Length == 1){
                        setNumbers[i] = setNumbers[i].Insert(setNumbers[i].Length, "0");}
                }
                
                //Trying to convert the set to a valid number
                if (!decimal.TryParse(setNumbers[i], out tryingtoZero)){
                    //Its a number out of bundaries
                    throw new ArgumentOutOfRangeException(EnglishErrorMessages.Error_InvalidInput + " " + EnglishErrorMessages.Reason_IntegerOutOfBoundaries);}
                //If it's zero just print zero and skip the iteration
                if (tryingtoZero == 0){
                   setNumbers[i] = "0";
                   outputText += "zero ";
                }else{//Start the iteration of sets
                   outputText += number.IterationOfSets(setNumbers[i]);}
            }
            return outputText + moneyValue.Trim();
        }


        /// <summary>
        /// Converts any number including decimals into the correpsonding text.
        /// </summary>
        /// <param name="inputNumber">Any positive number including decimals.</param>
        /// <returns>The corresponding text for the value of the number.</returns>
        /// <remarks>This method is mainly to test the STATIC method in the Unit Testing. </remarks>
        public string TestCallToText(string inputNumber)
        {
            return ToText(inputNumber);
        }
        #endregion

        #region PrivateMethods
      
        /// <summary>
        /// Iterates the input number in sets of three digits representing Trillion-Billion-Million-Thousands-Hundreds
        /// </summary>
        /// <param name="number">Set of numbers to be converted in text.</param>
        /// <returns>Text corresponding to the set of numbers.</returns>
        private string IterationOfSets(string number)
        {
            List<string> listScaleTypeText = EnglishDictionary.ScaleNumbers;

            string ouputtext=string.Empty;
            string setNumberString = number;
            
            double numberLenght = (double)number.Length;
            double totalSets = Math.Ceiling(numberLenght / 3);

            decimal setNumberInt = 0;
            int valuesToTake = 0;
            int setPosition = 0;
            int scalePosition = 0;

            //Iteration of sets of three numbers
            for (int set = 0; set <= totalSets; set++)
            {
                valuesToTake = ValidateSetPosition(set, number);
                //Validate that the position of the number to evaluate is smaller than the lenght of the number to avoid an Index out of boundaries
                if (setPosition < numberLenght)
                {
                    setNumberString = number.Substring(setPosition, valuesToTake);
                    setNumberInt =  Convert.ToInt32(setNumberString);
                    setPosition = setPosition + valuesToTake;
                    scalePosition = Convert.ToInt32(totalSets-1) - set;
                    if (setNumberInt > 0){
                        ouputtext = IterationOfNumbers(setNumberString.Length, setNumberInt, ouputtext) + listScaleTypeText[scalePosition];
                    }
                }
                
            }
            return ouputtext;
        }

        /// <summary>
        /// Iterates a set of three numbers representing Hundreds-Tens-Naturals
        /// </summary>
        /// <param name="position">Position of the number</param>
        /// <param name="number">Number</param>
        /// <param name="outputText">Number in text format.</param>
        /// <returns>Number in text format.</returns>
        private string IterationOfNumbers(int position, decimal number, string outputText)
        {
            decimal nextNumber = 0;
            //Validation for 0
            if (number == 0 && outputText.Length > 0){
                return outputText;
            }
            switch (ValidateNumberPosition(position, number))
            {
                case 1: //Number from 0-9
                    outputText += NumberToText(number, EnglishDictionary.NaturalTeenNumbers);
                    return outputText;
                case 2: //Number from 10-99
                    if (number < 20){
                        //Number from 10-19
                        outputText += NumberToText(number, EnglishDictionary.NaturalTeenNumbers);
                        return outputText;
                    }else{
                        //Number from 20-99
                        outputText += NumberToText((number/10), EnglishDictionary.TenNumbers);
                        nextNumber = number % 10;
                        return IterationOfNumbers(position - 1, nextNumber, outputText);
                    }
                case 3://Number from 100-999
                    if (number >= 100){
                        outputText += NumberToText(number / 100, EnglishDictionary.NaturalTeenNumbers) + NumberToText(10, EnglishDictionary.TenNumbers);
                        nextNumber = number % 100;
                    }else{
                        nextNumber = number;
                    }
                    return IterationOfNumbers(position - 1, nextNumber, outputText);
                default:
                    return outputText;
            }
            return outputText;
        }

        /// <summary>
        /// Validates that the set position is withing with the lenght of the number, so it takes the correct values to compose the set.
        /// </summary>
        /// <param name="setPosition">Set position</param>
        /// <param name="numberLenght">Lenght of the number</param>
        /// <returns>Number of position to take in the number.</returns>
        private int ValidateSetPosition(int setPosition, string number)
        {
            int valuesToTake = 0;
            double reminder = 0;
            double numberLenght = (double)number.Length;

            //In the first set we have to check how many digits we have based on the reminder
            if (setPosition == 0)
            {
                reminder = numberLenght % 3.0;
                //It has THREE digits
                if (reminder == 0) { valuesToTake = 3; }
                //It has ONE digit
                else if (reminder == 1) { valuesToTake = 1; }
                //It has TWO digits
                else { valuesToTake = 2; }

            }else{
                //Take three digits to create a set.
                valuesToTake = 3;
            }
            return valuesToTake;
        }

        /// <summary>
        /// Validates that the number matches with the lenght, so it's assigned to the correct position.
        /// </summary>
        /// <param name="numberPosition">Position of the number in the hundreds array.</param>
        /// <param name="number">Number</param>
        /// <returns>The correct position of the number on the array</returns>
        /// <example>
        /// Number=02, Posotion=2 (XXX-->X02), Correct Position=1 (XXX-->XX2)
        /// If we remove this validation 02 will return twenty instead of two
        /// </example>
        private int ValidateNumberPosition(int numberPosition, decimal number)
        {
            double numberGraterZero = Convert.ToDouble(number)/ Math.Pow(10, numberPosition - 1);
            if (numberGraterZero < 1)            {
                numberPosition = number.ToString().Length;
            }
            return numberPosition;
        }

        /// <summary>
        /// Converts a number into text.
        /// </summary>
        /// <param name="number">Number to be converted in text.</param>
        /// <param name="numbersCollection">Collection to look for the number.</param>
        /// <returns>Number in text format.</returns>
        private string NumberToText(decimal numberInput, Dictionary<int, string> numbersCollection)
        {

            int test = Convert.ToInt16(Math.Floor(numberInput));
            string numberInText = numbersCollection.Where(number => number.Key == test).Select(number => number.Value).FirstOrDefault();
            return numberInText;
        }
        #endregion
    }
}
