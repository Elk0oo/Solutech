using System;

namespace ToUpperV2
{
    //Version with a param and one method
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez écrire une phrase : ");
            string sentence = Console.ReadLine();
            Console.Write(sentence + "=>" + "[" + ToUpper(sentence,false) + "," + ToUpper(sentence,true) + "]");

        }

        /// <summary>
        /// Method to upper even and odd letters 
        /// </summary>
        /// <param name="value">sentence to update</param>
        /// <param name="odd">param to know if we want to upper the odd letters or the even letters</param>
        /// <returns>the updated sentence</returns>
        private static string ToUpper(string value, bool odd)
        {
            string res = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (!odd ? i % 2 == 0 : i % 2 != 0)
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
