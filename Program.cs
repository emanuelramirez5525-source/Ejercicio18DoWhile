// Escriba un programa que implemente un menú que se repita hasta que el usuario elija la opción de salir.

int opcion;
Random rnd = new Random();
do
{


    Console.WriteLine("MENU");
    Console.WriteLine("1. Mostrar saludo!");
    Console.WriteLine("2. Mostrar número aleatorio");
    Console.WriteLine("0 Salir");
    opcion = int.Parse(Console.ReadLine());


    switch (opcion)
    {

        case 1:

            Console.WriteLine("HOLAAAA");
            break;

        case 2:

            int numero = rnd.Next(1, 1000);
            Console.WriteLine("Número aleatorio: "+ numero);

            break;

        case 0:

            Console.WriteLine("Saliendo...");

            break;

        default:
            Console.WriteLine("Opcion invalida...");
            break;



    }



} while (opcion != 0);

