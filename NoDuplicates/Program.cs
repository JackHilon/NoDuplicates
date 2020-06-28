using System;

namespace NoDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            // No Duplicates
            // https://open.kattis.com/problems/nodup
            // check replicate item in the array


            var myStringArray = GetALine();
            var result = StringArrayCheck(myStringArray);
            Console.WriteLine(result);
        }
        private static string StringArrayCheck(string[] yourArray)
        {
            for (int i = 0; i < yourArray.Length-1; i++)
            {
                if (ItemExist(yourArray, yourArray[i], i+1) == true)
                    return "no";
            }
            return "yes";
        }

        private static bool ItemExist(string[] yourArray, string str, int yourIndex)
        {
            for (int i = yourIndex; i < yourArray.Length; i++)
            {
                if (yourArray[i] == str)
                    return true;
            }
            return false;
        }

        private static string[] GetALine()
        {
            string str = Console.ReadLine();
            string[] arr;
            try
            {
                arr = str.Split(' ');
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetALine();
            }
            return arr;
        }
    }
}
