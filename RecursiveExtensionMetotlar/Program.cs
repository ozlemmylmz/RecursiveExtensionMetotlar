using System;

namespace RecursiveExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive-Özyinelemeli
            //3^4
            int result = 1;
            for (int i = 1; i <5; i++)
            {
                result = result * 3;
                
            }
            Console.WriteLine(result);
            Işlemler instance = new Işlemler();
            Console.WriteLine(instance.Expo(3,4));

            //Extension
            string ifade = "Özlem Yılmaz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpace());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 5, 7, 1 };
            dizi.SortArray();
            dizi.EkranaYazdır();

            int sayı = 5;
            Console.WriteLine(sayı.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
          
        }
    }
    public class Işlemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            return Expo(sayi, üs - 1) * sayi;

        }
 

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
