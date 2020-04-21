using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {   
        public int solution(int[] A)
        {
            if(A.Length > 400000)
            {
                throw new Exception("El número de coordenadas no puede ser superior a 400.000");
            }
            List<Cumbre> cumbres = this.GetPicos(A);

            cumbres = this.GetCantidadCanones(cumbres);

            Task task = EnviarDronACumbres(cumbres);

            return cumbres.Count;
        }        

        private List<Cumbre> GetPicos(int[] valores)
        {
            List<Cumbre> Picos = new List<Cumbre>();
            int position = 0;
            foreach (int valor in valores)
            {
                if (position > 0)
                {
                    if(valor > 0 && valores[position - 1] < valor &&  valor > valores[position + 1])
                    {
                        if (valor > 1000000000)
                        {
                            throw new Exception("El valor de una coordenada no puede ser superior a 1000.000.000");
                        }
                        Console.WriteLine("Pico: " + valor + "Position" + position);

                        Picos.Add(new Cumbre 
                        { 
                            position = position,
                            Altura = valor
                        });
                    }
                }
                position++;
            }

            return Picos;
        }
        private List<Cumbre> GetCantidadCanones(List<Cumbre> Picos)
        {
            Console.WriteLine("Pico Definitivos");
            int picosCantidad = Picos.Count;
            List<Cumbre> PicoCanions = new List<Cumbre>();

            for (int i = 0; i < Picos.Count; i++)
            {
                if(i == 0)
                {
                    PicoCanions.Add(Picos[i]);
                    Console.WriteLine("Pico: " + Picos[i].Altura + " Position: " + Picos[i].position);
                }
                else if(Math.Abs(Picos[i].position) >= picosCantidad)
                {
                    PicoCanions.Add(Picos[i]);
                    Console.WriteLine("Pico: " + Picos[i].Altura + " Position: " + Picos[i].position);
                }
            }            

            return PicoCanions;
        }

        private async Task EnviarDronACumbres(List<Cumbre> cumbresDeMontaña)
        {            
            foreach(Cumbre cumbre in cumbresDeMontaña)
            {
                Console.WriteLine("Colocando cañon en cumbre {0} con posición {1}", cumbre.Altura, cumbre.position);
                await Task.Delay(5000);
                Console.WriteLine("Cañon colocado en cumbre {0} con posición {1}", cumbre.Altura, cumbre.position);
            }
        }
    }
}
