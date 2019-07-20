using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleatoriosConsola
{
    class Program
    {
        static bool Espar(int num)
        {
            return num % 2 == 0;
        }

        public static Boolean NumeroPrimo(int num)
        {
            return num % 2 != 0;
        }

        static void Main(string[] args)
        {
            Random NumeroAleatorio = new Random();
            List<int> NumPrimo = new List<int>();



            //•	Mostrar en consola todos los números primos.
            for (int i = 1; i <= 10; i++)
            {
                NumPrimo.Add(NumeroAleatorio.Next(40, 55));
            }
            Console.WriteLine("Lista Aleatoria");
            NumPrimo.ForEach(ale => Console.WriteLine(ale));
            Console.WriteLine("CAMBIANDO");            



            //•	Mostrar en consola la suma de todos los elementos.
            int ta = 0;
            NumPrimo.ForEach(ale => { ta = ta + ale; });
            Console.WriteLine("La Suma es {0}");
            Console.WriteLine("CAMBIANDO");



            //•	Generar una nueva lista con el cuadrado de los números.
            Console.WriteLine("El Cuadrado es: ");
            List<int> NumPrimo1 = new List<int>();
            NumPrimo.ForEach(ale=> NumPrimo1.Add(ale * ale));
            NumPrimo1.ForEach(ale => Console.WriteLine(ale));



            //•	Generar una nueva lista con los números primos.
            List<int> NuevaLista = new List<int>();
            var numprim = from ale in NumPrimo where NumeroPrimo(ale) select ale;
            foreach (var item in numprim)
            {
                NumPrimo.Add(item);
            }
            Console.WriteLine("La Suma es {0}");
            NumPrimo.ForEach(ale => Console.WriteLine(ale));



            //•	Optener el promedio de todos los números mayores a 50.
            Console.WriteLine("CAMBIANDO");
            var NumMayor = from i in NumPrimo where i > 50 select i;
            int h = 0, g = 0;
            Console.WriteLine("Mayores a 50: ");
            foreach (var item in NumMayor)
            {
                h++;
                g = g + item;
                Console.WriteLine(item);
            }
            g = g / h;
            Console.WriteLine("El Promedio es {0}", g);



            //•	Contar la cantidad de números pares e impares. Este problema debe 
            //resolverse en una única sentencia o en un solo querie.
            int l = 0, m = 0;
            NumPrimo.ForEach(ale => { if (Espar(ale)) { l++; } else { m++; } });
            Console.WriteLine("La Cantidad de Pares es {0} \n" + "La Cantidad de Impares es {1} \n", l, m);



            //•	Mostrar en consola, el número y la cantidad de veces que este se encuentra en la lista.
            var result = from i in NumPrimo select i;
            foreach (var item in result.Select((ale) =>
            new { Valor = ale }).GroupBy(ale => ale.Valor)
                .Select(ale => new{ Valor = ale.Key, Cantidad = ale.Count()}))
            {
                Console.WriteLine(string.Format("Numeros {0} \n" 
                    + "Cantidad de Veces {1} \n", item.Valor, item.Cantidad));
            }
            Console.WriteLine("CAMBIANDO");



            //•	Mostrar en consola los elementos de forma descendente.
            Console.WriteLine("Numeros Ordenados: ");
            (from ale in NumPrimo orderby ale descending select ale).ToList().ForEach(ale => Console.WriteLine(ale));

            Console.WriteLine("CAMBIANDO");



            //•	Mostrar en consola los número unicos.
            int sumatoria = 0;
            NumPrimo.ForEach(ale =>
            {
                int contador = 0;

                foreach (var item in NumPrimo)
                {
                    if (item == ale)
                    {
                        contador++;
                    }
                }
                if (contador == 1)
                {
                    sumatoria= sumatoria+ale;
                    Console.WriteLine("unicos {0}", ale);
                }
            });



            //•	Sumar todos los números unicos de la lista.
            Console.WriteLine("La Suma es {0}", sumatoria);

            Console.WriteLine("CAMBIANDO");

            (from ale in NumPrimo select ale).ToList().ForEach(ale => Console.WriteLine(ale));

            Console.ReadKey();
        }
    }
}
