using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzando Proceso");
            try
            {
                CortarString();
                //Solution sol = new Solution();
                //int[] A = new int[] { 1, 6, 4, 5, 1, 2, 3, 4, 7, 2 };
                ////int[] A = new int [0] ;
                //int cantidadDePicos = sol.solution(A);
                //Console.WriteLine("Cantidad de picos: " + cantidadDePicos);

                //int[] B = new int[] { 1, 6, 4, 5, 4, 5, 1, 2, 3, 4, 7, 2 };
                //int cantidadDePicos2 = sol.solution(B);
                //Console.WriteLine("Cantidad de picos: " + cantidadDePicos2);
                Console.WriteLine("Proceso Ok");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }            
        }

        private static void CortarString()
        {
            StringBuilder cortar = new StringBuilder();
            cortar.Append("12345678901");
            Console.WriteLine("Intenta extraer 50");
            Console.ReadLine();
            Console.WriteLine(cortar.ToString().Substring(0, 10));
            Console.WriteLine(cortar.ToString().Substring(0, 10));
            Console.ReadLine();
            //cortar.Length = 5;
            Console.WriteLine(cortar.ToString());
            Console.WriteLine("cantidad" + cortar.Length.ToString());
            Console.ReadLine();
        }
    }
}
