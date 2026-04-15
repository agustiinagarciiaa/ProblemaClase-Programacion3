using System;

namespace Programa
{
  class Program
    {
        static void Main(string[] args)
        {
            //Resolucion de clase

            Console.WriteLine("\n---Entrada de boliche---");

            //Estos son los arrays con los que voy a almacenar los nombres junto a su respectiva edad
            string [] nombre = new string [20];
            int [] edad = new int [20];
            int ingresaron = 0;


            //Utilice el for para que recorra los arrays y muestre los datos ingresados
            for(int i = 0; i < 20; i++)
            {

                Console.WriteLine("Ingrese su nombre, por favor: ");
                nombre [i] = Console.ReadLine()!; 

                Console.WriteLine("Ingrese su edad, por favor: ");
                edad [i] = int.Parse(Console.ReadLine())!;

            /*Para finalizar utilice if y else para darle la condicion de que si el array de edad 
            es menor de 20 años ¡No puede ingresar! pero si es mayor de edad si puede ingresar al boliche 
            y tambien le agrego el ingresaron++ para sumar las personas que vaya entrando*/
                if (edad [i] < 20)
                {
                    Console.WriteLine(nombre[i] + " Porfavor vuelva a su casa, cuidese! :D ");
                } else
                {
                    Console.WriteLine(nombre[i] + " Puede ingresar, disfrute la noche");
                    ingresaron++;
                }
            }

            //Fuera de mi for utilizo un Console.WriteLine para mostrar el total de personas que ingresaron

            Console.WriteLine("Total de personas que ingresaron:  " + ingresaron);

            //Fin del ejercicio 
            Console.WriteLine("\nPresione ENTER para cerrar");
            Console.ReadLine();
        }
    }
}