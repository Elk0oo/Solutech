using System;

namespace ToUpperV2
{
    //Version avec un paramètre supplémentaire et une méthode
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez écrire une phrase : ");
            string sentence = Console.ReadLine();
            Console.Write(sentence + "=>" + "[" + ToUpper(sentence,false) + "," + ToUpper(sentence,true) + "]");

        }

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
