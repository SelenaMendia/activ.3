using System;

namespace activ._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0, suma=0, promedio;
            int [] arregloNumerico = new int [5];

            for (int i = 0; i < arregloNumerico.Length;i++)
            {
                Console.WriteLine("Ingrese el numero que quiere almacenar del elemento de indice {0} :", i);
                numero=Convert.ToInt32(Console.ReadLine());
                arregloNumerico[i]=numero;
                suma=suma+arregloNumerico[i];

            }
            promedio=suma/arregloNumerico.Length;

            Console.WriteLine("El promedio de los numeros ingresados es: {0}%",promedio);
            
        }
    }
}
