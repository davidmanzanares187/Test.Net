using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzando Proceso");
            try
            {
                Solution sol = new Solution();
                int[] A = new int[] { 1, 6, 4, 5, 1, 2, 3, 4, 7, 2 };                
                int cantidadDePicos = sol.solution(A);
                Console.WriteLine("Cantidad de picos: " + cantidadDePicos);

                int[] B = new int[] { 1, 6, 4, 5, 4, 5, 1, 2, 3, 4, 7, 2 };
                int cantidadDePicos2 = sol.solution(B);
                Console.WriteLine("Cantidad de picos: " + cantidadDePicos2);
                Console.WriteLine("Proceso Ok");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }            
        }
    }
}
