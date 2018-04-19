using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    // the RomantoArabic class
    class RomantoArabic
    {

        // I am getting the dictionary map letters, I am just defining them
        // pulls them from the dictionary 
        public static Dictionary<string, int> Romanmap = new Dictionary<string, int>()
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000},
        };

        public static int romantoint(string roman)
        {
            try
            {

                

                // declares a variable int, starts at 0
                int number = 0;
                for (int i = 0; i < roman.Length; i++)
                {

                    // pulling from the dictionary,the specified input from the dictionary 
                    // then it will pull its equivalent from the dictionary

                    if (i + 1 < roman.Length && Romanmap[roman[i].ToString()] < Romanmap[roman[i + 1].ToString()])
                    {
                        number -= Romanmap[roman[i].ToString()];
                    }

                    else
                    {
                        number += Romanmap[roman[i].ToString()];






                    }

                }

                    /*  if statements that would input an error if the incorrect formatting
                     was implemented. i.e: XXXX = 40*/

                if (roman.Contains("VV") || roman.Contains("LL") || roman.Contains("DD"))
                {
                    throw new System.InvalidOperationException(" No doubling numbers");
                }

                if (roman.Contains("IIII") || roman.Contains("XXXX") || roman.Contains("CCCC"))
                {
                    throw new System.InvalidOperationException("No doubling on numbers");
                }

                if (roman.Contains("MMMM"))
                {
                    throw new System.InvalidOperationException("No doubling on numbers");
                }


                // returns the number
                return number;

            }

            catch (Exception ex)
            {
                throw (ex);
            }



        }
    }

    // Made a class for the arabictoroman
    class arabictoroman
    {

        
        public static Dictionary<string, int> romanmap = new Dictionary<string, int>()

        {

            {"I", 1 },
            {"IV", 4 },
            {"V", 5 },
            {"IX", 9 },
            {"X", 10 },
            {"XL", 40 },
            {"L", 50 },
            {"XC" , 90},
            {"C", 100 },
            {"CD" , 400},
            {"D", 500 },
            {"CM" , 900},
            {"M", 1000 },

        };

        public static string inttoroman(int roman)
        {

            try
            {

                /* declare to variables, one as the inputvalue that the user inputs and 
                  a string that will be the ouput converted*/
                
                int inputvalue = roman;
                string outputvalue = "";



                /* An if statement that specifies that the input value entered must be no less than 1
                   or greater than 39998*/
                if ( inputvalue < 1 || inputvalue >= 4000)
                {
                    throw new System.InvalidOperationException("input must be betweeen 1 and 3999");
                }


                while (inputvalue / 1000 != 0)
                {
                    inputvalue = (inputvalue - 1000);
                    outputvalue = (outputvalue + "M");
                }

                while (inputvalue / 900 != 0)
                {
                    inputvalue = (inputvalue - 900);
                    outputvalue = (outputvalue + "CM");
                }

                while (inputvalue / 500 != 0)
                {
                    inputvalue = (inputvalue - 500);
                    outputvalue = (outputvalue + "D");
                }


                while (inputvalue / 400 != 0)
                {
                    inputvalue = (inputvalue - 400);
                    outputvalue = (outputvalue + "CD");
                }

                while (inputvalue / 100 != 0)
                {
                    inputvalue = (inputvalue - 100);
                    outputvalue = (outputvalue + "C");
                }

                while (inputvalue / 90 != 0)
                {
                    inputvalue = (inputvalue - 90);
                    outputvalue = (outputvalue + "XC");
                }

                while (inputvalue / 50 != 0)
                {
                    inputvalue = (inputvalue - 50);
                    outputvalue = (outputvalue + "L");
                }

                while (inputvalue / 40 != 0)
                {
                    inputvalue = (inputvalue - 40);
                    outputvalue = (outputvalue + "XL");
                }

                while (inputvalue / 10 != 0)
                {
                    inputvalue = (inputvalue - 10);
                    outputvalue = (outputvalue + "X");
                }


                while (inputvalue / 5 != 0)
                {

                    if (inputvalue == 9)
                    {
                        inputvalue = (inputvalue - 9);
                        outputvalue = (outputvalue + "IX");

                    }


                    else
                    {

                        inputvalue = (inputvalue - 5);
                        outputvalue = (outputvalue + "V");

                    }

                }

                while (inputvalue / 1 != 0)
                {

                    if (inputvalue / 1 > 3)
                    {
                        inputvalue = (inputvalue - 4);
                        outputvalue = (outputvalue + "IV");
                    }

                    else

                    {

                        inputvalue = (inputvalue - 1);
                        outputvalue = (outputvalue + "I");


                    }
                }

                return outputvalue;

            }
            catch (Exception ex)
            {
                throw (ex);
            }




        }
    }

}















            

