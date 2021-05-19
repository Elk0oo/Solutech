using System;

namespace ToUpperV1
{
    //Version with two methods
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez écrire une phrase : ");
            string sentence = Console.ReadLine();            
            Console.Write(sentence+"=>"+"["+ToUpperEven(sentence)+","+ToUpperOdd(sentence)+"]");

        }


        /// <summary>
        ///Method to upper even letter 
        /// </summary>
        /// <param name="value">sentence to update</param>
        /// <returns>the sentence with the even letters in capitals</returns>
        private static string ToUpperEven(string value)
        {
            string res = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (i % 2 == 0)
                {
                    res += value[i].ToString().ToUpper();
                }
                else
                {
                    res += value[i];
                }
            }
            return res;
        }

        /// <summary>
        ///Method to upper odd letter 
        /// </summary>
        /// <param name="value">sentence to update</param>
        /// <returns>the sentence with the odd letters in capitals</returns>
        private static string ToUpperOdd(string value)
        {
            string res = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (i % 2 != 0)
                {
                    res += value[i].ToString().ToUpper();
                }
                else
                {
                    res += value[i];
                }
            }
            return res;
        }
    }
}
