using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RTS_Labs_Exercise
{
    //    Please write a class in the language of your choice that contains the following two public methods:

    //  aboveBelow
    //  accepts two arguments
    //  a collection of integers(the list)
    //  an integer(the comparison value)
    //  returns a hash/object/map/etc.with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value
    //  Example usage:

    //  input: [1,2,3,4,5,6], 3

    //  output: { "above": 3, "below": 2 }

    //  2.stringRotation

    //  accepts two arguments
    //  a string (the original string)
    //  a positive integer (the rotation amount)
    //  returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning
    //  Example usage:

    //  input: "MyString", 2

    //  output: "ngMyStri"


    #region Exception Definitions

    public class AboveBelowException : Exception
    {
        private string _msg = string.Empty;
        public override string Message => _msg;

        public AboveBelowException(string msg)
        {
            _msg = msg;
        }

        public AboveBelowException()
        {
        }
    }

    public class AboveBelowNullException : AboveBelowException
    {
        public AboveBelowNullException(string msg) : base(msg)
        {
        }
    }

    public  class StringRotationEmptyOrNullException : Exception
    {
        private string _msg = string.Empty;
        public override string Message => _msg;
        public StringRotationEmptyOrNullException(string msg)
        {
            _msg = msg;
        }
        
        public StringRotationEmptyOrNullException() {}
    }

    #endregion

    public static class CodingExercise
    {
        public static IDictionary<string, int> aboveBelow(Collection<int> input, int comparitor)
        {
            if (input is null) throw new AboveBelowNullException("Input collection cannot be null");
            if (input.Count == 0) throw new AboveBelowException("Input collection cannot have a size of zero.");
            var above = input.Where(value => value > comparitor).Count();
            var below = input.Where(value => value < comparitor).Count();
            return new Dictionary<string, int>()
            {
                {"above", above },
                {"below", below }
            };
        }
        
        public static string stringRotation(string input, int rotAmt)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new StringRotationEmptyOrNullException("You cannot use an empty or null string as an input");
            if (rotAmt == 0) return input;
            return Math.Sign(rotAmt) == 1 ? PositiveRotation(input, rotAmt) : NegativeRotation(input, Math.Abs(rotAmt)); 
        }

        private static string NegativeRotation(string input, int rotAmt)
        {
            return PositiveRotation(input, input.Length - rotAmt);
        }

        private static string PositiveRotation(string input, int rotAmt)
        {
            return input.Substring(input.Length - rotAmt) + input.Substring(0, input.Length - rotAmt);
        }

    }
}
