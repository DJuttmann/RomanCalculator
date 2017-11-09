﻿﻿//========================================================================================
// RomanCalculator by Daan Juttmann
// Created: 2017-11-09
// License: GNU General Public License 3.0 (https://www.gnu.org/licenses/gpl-3.0.en.html).
﻿//========================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;

namespace RomanCalculator
{
  class RomanNumerals
  {
    public enum Operator
    {
      Add,
      Subtract,
      Multiply,
      Divide
    }

    private static uint RomanMax = 9999; // largest number supported by calculator
    private static string ErrorOverflow = "Error: overflow";
    private static string ErrorUnderflow = "Error: underflow";
    private static string ErrorDivideByZero = "Error: divide by zero";
    public static string RomanZero = "nulla";
    private static Regex RomanNumeral = new Regex 
      ("^M{0,9}(C{1,4}|CD|DC{0,4}|CM)?(X{1,4}|XL|LX{0,4}|XC)?(I{1,4}|IV|VI{0,4}|IX)?$");
      // regex that matches any valid Roman numeral up to 9999
    private static string [] Digit0 = new []
      {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
    private static string [] Digit1 = new []
      {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
    private static string [] Digit2 = new []
      {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
    private static string Digit3 = "MMMMMMMMMM";

    // METHODS
      
    // Convert roman digit to uint, returns 0 on invalid character.
    private static uint DigitRomanToInt (char c)
    {
      switch (c)
      {
      case 'I':
        return 1;
      case 'V':
        return 5;
      case 'X':
        return 10;
      case 'L':
        return 50;
      case 'C':
        return 100;
      case 'D':
        return 500;
      case 'M':
        return 1000;
      default:
        break;
      }
      return 0;
    }


    // Convert roman numeral to uint.
    public static uint RomanToInt (string roman)
    {
      uint [] digits = new uint [roman.Length];
      uint sum = 0;
      for (int i = 0; i < roman.Length; i++)
      {
        digits [i] = DigitRomanToInt (roman [i]);
      }
      for (int i = 0; i < digits.Length;)
      {
        if (i < digits.Length - 1 && digits [i] < digits [i + 1])
        {
          sum += digits [i + 1] - digits [i];
          i += 2;
        }
        else
        {
          sum += digits [i];
          i += 1;
        }
      }
      return sum;
    }


    // Convert uint to Roman numeral.
    public static string IntToRoman (uint number)
    {
      StringBuilder roman = new StringBuilder ("");
      if (number > RomanMax)
        return "Error: Overflow";
      if (number == 0)
        return RomanZero;
      roman.Append (Digit3.Substring (0, (int) (number / 1000)));
      number %= 1000;
      roman.Append (Digit2 [number / 100]);
      number %= 100;
      roman.Append (Digit1 [number / 10]);
      number %= 10;
      roman.Append (Digit0 [number]);
      return roman.ToString ();
    }


    // Check if string contains valid Roman numeral.
    public static bool ValidateRomanNumeral (string roman)
    {
      return RomanNumeral.IsMatch (roman);
    }


    // Evaluate an exprssion and return as Roman numeral.
    public static string Evaluate (uint LHS, uint RHS, Operator op)
    {
      uint eval;
      switch (op)
      {
      case Operator.Add:
        eval = LHS + RHS;
        if (eval > RomanMax)
          return ErrorOverflow;
        break;
      case Operator.Subtract:
        if (LHS < RHS)
          return ErrorUnderflow;
        eval = LHS - RHS;
        break;
      case Operator.Multiply:
        eval = LHS * RHS;
        if (eval > RomanMax)
          return ErrorOverflow;
        break;
      case Operator.Divide:
        if (RHS == 0)
          return ErrorDivideByZero;
        eval = LHS / RHS;
        break;
      default: // this should never happen
        return "Invalid operator";
      }
      return IntToRoman (eval);
    }
  }



  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ()
    {
      Application.EnableVisualStyles ();
      Application.SetCompatibleTextRenderingDefault (false);
      Application.Run (new Form1 ());
    }
  }
}
