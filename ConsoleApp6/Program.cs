

using System;

namespace ConsoleApp6
{
    public class Program
    {
        

        static void Main(string[] args)
        {

            PrintArrayforAsc();
            //Numbersum();

        }


        public static void PrintArrayforAsc()
        {

            int[] Array1 = new int[10];
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine("sheiyvanet " + (i + 1) + " ricxvsi:");
                
                Array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < Array1.Length; i++)
            {
                Array.Sort(Array1);
                Console.Write(Array1[i] + " ");
              

            }
            
            int largest = Array1.Max();
            int smallest = Array1.Min();

            var tosum = largest - smallest;
            Console.WriteLine("yvelaze didi da patara wevrebis sxvaoba : " + tosum);

            Console.ReadKey();

            int val;
            for (val = 1; val <= Array1.Length; val++)
            {
                if (Array1[val - 1] % 3 == 0 && Array1[val - 1] % 2 == 0)
                {
                    Console.WriteLine("luwebi da 3 jeradebi:  " + Array1[val-1]);
                }
                

            }

            int Odd;
            for (Odd = 1; Odd <= Array1.Length; Odd++)
            {
                if (Array1[Odd - 1] % 2 - 1 == 0)
                {
                    Console.WriteLine("kenti: " + Array1[Odd - 1]);
                }


            }



            var result = 0;
            for (int i = 0; i < Array1.Length; i++)
                result += Array1[i];
            Console.WriteLine("masivis wevrebis jami: " + result);



        }

        public static void Numbersum()
        {
          
            
        }
    }
    
}