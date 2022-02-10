using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberConverter
  {
    public string Number { get; set; }

    public NumberConverter(string number)
    {
      Number = number;
    }

    public Dictionary <char, string> numberDictionary = new Dictionary<char, string>()
    { {'0', ""},
      {'1',"one"},
      {'2', "two"},
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"}
    };
      public Dictionary<char, string> teenDictionary = new Dictionary<char, string>()
    {
      {'0',"ten"},
      {'1', "eleven"},
      {'2', "twelve"},
      {'3', "thirteen"},
      {'4', "fourteen"},
      {'5', "fifteen"},
      {'6', "sixteen"},
      {'7', "seventeen"},
      {'8', "eighteen"},
      {'9', "nineteen"}
    };
      public Dictionary<char, string> tensDictionary = new Dictionary<char, string>()
    {
      {'2', "twenty"},
      {'3', "thirty"},
      {'4', "fourty"},
      {'5', "fifty"},
      {'6', "sixty"},
      {'7', "seventy"},
      {'8', "eighty"},
      {'9', "ninety"},
    };
    public string ConvertNumberToWord() 
    {
      // string number =Console.ReadLine(); 
      string result = "";

      if (Number.Length == 1)
      {
        result = numberDictionary[Number[0]]; 
        return result;
      }
      else if (Number.Length == 2 && (Number[0] == '1'))
      {
        result = teenDictionary[Number[1]];
        return result;
      }
      else if (Number.Length == 2)
      {
        result =(tensDictionary[Number[0]] + numberDictionary[Number[1]]);
        // Console.WriteLine(result);
        return result;
      }
      else
      {
        return "bupkis";
      }
    }
  }
}

