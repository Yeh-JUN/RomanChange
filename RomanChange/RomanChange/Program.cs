using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanChange
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public int RomanToInt(string s)
        {
            int totalSum = 0;
            string str = s;
            if (str.Contains("IV"))
            {
                totalSum += 4;
                str = str.Replace("IV", "");
            }
            if (str.Contains("IX"))
            {
                totalSum += 9;
                str = str.Replace("IX", "");
            }
            if (str.Contains("XL"))
            {
                totalSum += 40;
                str = str.Replace("XL", "");
            }
            if (str.Contains("XC"))
            {
                totalSum += 90;
                str = str.Replace("XC", "");
            }
            if (str.Contains("CD"))
            {
                totalSum += 400;
                str = str.Replace("CD", "");
            }
            if (str.Contains("CM"))
            {
                totalSum += 900;
                str = str.Replace("CM", "");
            }

            char[] arrStr = str.ToCharArray();
            for (int i = 0; i < arrStr.Length; i++)
            {
                switch (arrStr[i].ToString())
                {
                    case "I":
                        totalSum += 1;
                        break;

                    case "V":
                        totalSum += 5;
                        break;

                    case "X":
                        totalSum += 10;
                        break;

                    case "L":
                        totalSum += 50;
                        break;

                    case "C":
                        totalSum += 100;
                        break;

                    case "D":
                        totalSum += 500;
                        break;

                    case "M":
                        totalSum += 1000;
                        break;
                }
            }
            return totalSum;
        }
    }
}
