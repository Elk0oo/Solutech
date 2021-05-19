using System;

namespace ToUpperV1
{
    //Version avec deux méthodes différentes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez écrire une phrase : ");
            string sentence = Console.ReadLine();            
            Console.Write(sentence+"=>"+"["+ToUpperEven(sentence)+","+ToUpperOdd(sentence)+"]");

        }

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
