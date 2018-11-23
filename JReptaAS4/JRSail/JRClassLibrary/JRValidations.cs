using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;


namespace JRClassLibrary
{
    public static class JRValidations
    {
        /// <summary>
        /// Capitalizes first letter of every word in string, lowers everything else
        /// </summary>
        /// <param name="input">String</param>
        /// <returns>Capitalized first letters, lower-case words</returns>
        public static string JRCapitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.Trim().ToLower());
        }

        /// <summary>
        /// Extracts all digits from input string and returns them
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>All digits contained in input string</returns>
        public static string JRExtractDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string output = "";

            foreach (char item in input)
            {
                if (char.IsDigit(item))
                {
                    output += item;
                }
            }
            return output;
        }

        /// <summary>
        /// Checks for valid Canadian postal code. Middle space and cases irrelevant. Accepts null or empty, but not whitespace
        /// </summary>
        /// <param name="input">Likes null, empty, or proper Canadian postal Code</param>
        /// <returns>True for valid postal, null or empty. False otherwise.</returns>
        public static bool JRPostalCodeValidation(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            Regex regex = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input) ? true : false;
        }

        /// <summary>
        /// Places a space into the middle of a validated Canadian Postal Code, capitalizes
        /// </summary>
        /// <param name="input">Valid Canadian Postal Code</param>
        /// <returns>Capitalized Canadian Postal Code with middle space</returns>
        public static string JRPostalCodeFormat(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            if (input.Trim().Length == 6)
            {
                input.Insert(3, " ");
            }
            return input.ToUpper();
        }

        /// <summary>
        /// Validates 5 or 9 digit US zip code, extracted from a string.
        /// </summary>
        /// <param name="inputRef">Any string with 5 or 9 digits that are a valid US zip code</param>
        /// <returns>Only extracted US zip Code</returns>
        public static bool JRZipCodeValidation(ref string inputRef)
        {
            if (string.IsNullOrEmpty(inputRef))
            {
                inputRef = "";
                return true;
            }
            string extract = JRExtractDigits(inputRef);
            if (int.TryParse(inputRef, out int result))
            {
                return false;
            }
            if (extract.Length == 5)
            {
                inputRef = extract;
                return true;
            }
            if (extract.Length == 9)
            {
                extract.Insert(5, "-");
                return true;
            }
            return false;
        }

    }
}
