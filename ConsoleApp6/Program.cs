

namespace ConsoleApp6
{
    internal class Program
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
                Console.WriteLine("Please enter the " + (i + 1) + " number of the first array:");
                
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
            Console.WriteLine("sum: " + tosum);

            Console.ReadKey();

            int val;
            for (val = 1; val <= Array1.Length; val++)
            {

                if (Array1[val-1] % 2 == 0)
                {
                    Console.WriteLine(Array1[val-1]);
                }
                //if (Array1[val - 1] / 3 == 0)
                //{
                //    Console.WriteLine(Array1[val - 1]);
                //}

            }


            var result = 0;
            for (int i = 0; i < Array1.Length; i++)
                result += Array1[i];
            Console.WriteLine("jami aris: "+ result);


        }

        public static void Numbersum()
        {
            
        }
    }
    
}