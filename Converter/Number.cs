using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterController
{
    /// <summary>
    /// Converter for numbers. 
    /// </summary>
    public class Number
    {
        #region Methods
        /// <summary>
        /// Converts any positive number including decimals into the correpsonding text.
        /// </summary>
        /// <param name="inputNumber">Any positive number including decimals.</param>
        /// <returns>The corresponding text for the value of the number.</returns>
        public static string ToText(string inputNumber)
        {
            //TODO: The culture could be added as a parmater or do a bit of research so we set other languages
            EnglishDictionary.LoadNumbers();
            string outputText = string.Empty;
            long tryingtoZero = 0;

            Number number = new Number();

            //Getting sets of numbers: integers and decimals
            string[] setNumbers = inputNumber.Split(new char[] { '.' });
            for (int set=0; set < setNumbers.Length; set++)
            {
                if(set==1){
                    outputText += EnglishDictionary.Dot;
                    //Filling in the set with 000 to the right just for a max of two decimals
                    if (setNumbers[set].Length == 1)
                    {
                       setNumbers[set]= setNumbers[set].Insert(setNumbers[set].Length, "0");
                    }
                }
                //Initializing the sets with zero
                if (setNumbers[set] == ""){
                    setNumbers[set] = "0";
                }

                //Trying to convert the set to a valid number
                if (Int64.TryParse(setNumbers[set], out tryingtoZero))
                {
                    //If it's zero just print zero and skip the iteration
                    if (tryingtoZero == 0)
                    {
                        setNumbers[set] = "0";
                        outputText += "zero ";
                    }else{//Start the iteration of sets
                        outputText += number.IterationOfSets(setNumbers[set]);
                    }
                }
            }
            return outputText;
        }

        /// <summary>
        /// Im creating this method as a temporary call for the STATIC method
        /// Thsi methos is used solely on teh unit testing, as I have tocheck how to do unit testic for static methdos
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        public string CallToText(string inputNumber)
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
        private  string IterationOfSets(string number)
        {
            List<string> listScaleTypeText = EnglishDictionary.ScaleNumbers;

            string ouputtext=string.Empty;
            string setNumberString = number;
            
            double numberLenght = (double)number.Length;
            double totalSets = Math.Ceiling(numberLenght / 3);

            int setNumberInt = 0;
            int valuesToTake = 0;
            int setPosition = 0;
            int scalePosition = 0;

            //Iteration of sets of three numbers
            for (int set = 0; set <= totalSets; set++)
            {
                valuesToTake = ValidateSetPosition(set, numberLenght);
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
        private  string IterationOfNumbers(int position, Int64 number, string outputText)
        {
            Int64 nextNumber = 0;
            //Validation for 0
            if (number == 0 && outputText.Length > 0){
                return outputText;
            }
            switch (ValidateNumberPosition(position, number))
            {
                case 1: //Number from 0-9
                    outputText += NumberToText(number, EnglishDictionary.NaturalTeenNumbers);
                    return outputText;
                    break;
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
                    break;
                case 3://Number from 100-999
                    if (number >= 100){
                        outputText += NumberToText(number / 100, EnglishDictionary.NaturalTeenNumbers) + NumberToText(10, EnglishDictionary.TenNumbers);
                        nextNumber = number % 100;
                    }else{
                        nextNumber = number;
                    }
                    return IterationOfNumbers(position - 1, nextNumber, outputText);
                    break;
                default:
                    return outputText;
                    break;
            }
            return outputText;
        }

        /// <summary>
        /// Validates that the set position is withing with the lenght of the number, so it takes the correct values to compose the set.
        /// </summary>
        /// <param name="setPosition">Set position</param>
        /// <param name="numberLenght">Lenght of the number</param>
        /// <returns>Number of position to take in the number.</returns>
        private  int ValidateSetPosition(int setPosition, double numberLenght)
        {
            int valuesToTake = 0;
            double reminder = 0;
           
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
        /// <example>Number=02, Posotion=2 (XXX-->X02), Correct Position=1 (XXX-->XX2)</example>
        private  int ValidateNumberPosition(int numberPosition, Int64 number)
        {
            //TODO: Check if this method is really necesary
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
        private  string NumberToText(Int64 numberInput, Dictionary<int, string> numbersCollection)
        {
            string numberInText = numbersCollection.Where(number => number.Key == numberInput).Select(number => number.Value).FirstOrDefault();
            return numberInText;
        }
        #endregion
    }
}
