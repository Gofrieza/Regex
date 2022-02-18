using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
        class Patterns
    {
        //public static string regex = "^([A-Za-z0-9]+[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        //public static string RegexRulesFor3char = "^([0-9]*[a-zA-Z]{3,})[0-9a-zA-Z]*$";
        //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        //public static string regex = "^[0-9]*[A-Za-z]{3,}[0-9A-Za-z]*$";
        //public static string regex = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        //public static string regex = "^[0-9]*[a-zA-Z]{3}[0-9A-Za-z]*$";
        //public static string regex = "^[A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{3}$";

        //public static string regex = "^[A-Z][A-Za-z]{2,}$";  //uc-1
        //public static string regex = "^[A-Z][A-Za-z]{2,}[ ][A-Z][A-Za-z]{2,}$";  //uc-2
        //public static string regex = "^[A-Za-z0-9]+([+.#_-][A-Za-z0-9]+)?[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2,3})?[,]?$";  //UC-3
        //public static string regex = "^[9][1][ ][1-9][0-9]{9}$";  //Uc-4
        //public static string regex = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&:;<>,.?/~_+-=]).{8,}$";  //Uc-5,6,7,8
        public static string regex = "^[A-Za-z0-9]+([+.#_-][A-Za-z0-9]+)?[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2,3})?[,]?$";  //UC-9  
        public bool validatePinCode(string sample)
            {
                return Regex.IsMatch(sample, regex);
            }
        }
}
