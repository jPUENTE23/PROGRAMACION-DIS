using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> lista1 = new List<dynamic>();
            List<dynamic> lista2 = new List<dynamic>();

            Console.WriteLine("Cuantos valores desea ingresar en la 1era lista?");
            int cantVal1 = int.Parse(Console.ReadLine());


            Console.WriteLine("LISTA 1\n");
            for (dynamic num = 0;  num<cantVal1; num++) {
                Console.WriteLine("Ingresa un valor: ");
                dynamic numl1 = Console.ReadLine();
                lista1.Add(numl1);
            }

            Console.WriteLine("Cuantos valores desea ingresar en la 2da lista?");
            int cantVal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("LISTA 2");
            for (dynamic num = 0; num < cantVal2; num++)
            {
                Console.WriteLine("Ingresa un valor: ");
                dynamic numl2 = Console.ReadLine();
                lista2.Add(numl2);
            }

            
            List<int> ListaResultads = ValidarListas(lista1, lista2);
            Console.WriteLine("El valor {0} se repite: {1}", lista1[0], ListaResultads[0]);
            Console.WriteLine("El valor {0} se repite: {1}", lista1[1], ListaResultads[1]);
            Console.WriteLine("El valor {0} se repite: {1}", lista1[2], ListaResultads[2]);

        }

        static List<int> ValidarListas(List<dynamic> ListaVal1, List<dynamic> ListaVal2)
        {
            List<int> listaComparacion = new List<int>();
            foreach (string dato in ListaVal1)
            {
                int incremento = 0;
                foreach (string dt in ListaVal2)
                {
                    if (dato == dt)
                    {
                        incremento += 1;
                    }
                }
                listaComparacion.Add(incremento);
            }
            return listaComparacion;
        }
    }
}
