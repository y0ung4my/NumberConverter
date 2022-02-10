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

    public Dictionary <string, string> numberDictionary = new Dictionary<string, string>()
    {
      {"1","one"},
      {"2", "two"},
      {"3", "three"},
      {"4", "four"},
      {"5", "five"},
      {"6", "six"},
      {"7", "seven"},
      {"8", "eight"},
      {"9", "nine"}
    };
      public Dictionary<string, string> teenDictionary = new Dictionary<string, string>()
    {
      {"10","ten"},
      {"11", "eleven"},
      {"12", "twelve"},
      {"13", "thirteen"},
      {"14", "fourteen"},
      {"15", "fifteen"},
      {"16", "sixteen"},
      {"17", "seventeen"},
      {"18", "eighteen"},
      {"19", "nineteen"}
    };
      public Dictionary<string, string> tensDictionary = new Dictionary<string, string>()
    {
      {"20", "twenty"},
      {"30", "thirty"},
      {"40", "fourty"},
      {"50", "fifty"},
      {"60", "sixty"},
      {"70", "seventy"},
      {"80", "eighty"},
      {"90", "ninety"},
    };
    public string ConvertNumberToWord() 
    {
      // string number =Console.ReadLine(); 
      string result = "";

      if (Number.Length == 1)
      {
        result = numberDictionary[Number]; 
        return result;
      }
      else if (Number.Length == 2 && (Number[0] == '1'))
      {
        result = teenDictionary[Number];
        return result;
      }
      else 
      {
        return "bupkis";
      }
    }
  }
}

