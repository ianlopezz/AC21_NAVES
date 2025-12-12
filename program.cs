static void Main(string[] args)
{

    NavesEstelares [] naves = NavesEstelares (5);
    bool salir = false;
    
    
    
     while (!salir)
    {
        Console.WriteLine("¿Qué desea hacer?");
        Console.WriteLine("1. Crear una nave");
        Console.WriteLine("2. Cambiar el nombre de la nave");
        Console.WriteLine("3. Listar todas las naves");
        Console.WriteLine("4. Eliminar todas las naves");
        Console.WriteLine("5. Salir del menú");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1: // CREAR
            Console.WriteLine("Has elegido la opción 1");

            string [] Nombres = {"HALCONMILNEARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING"};
            Random generador = new Random (0,4);
            int indiceAleatorio = generador.Next(nombres.Length);
            string nombreElegido = Nombres[indiceAleatorio];
               
            Random Numero = new Random();
            int NumeroAleatorio = generador.Next(10-99);
            int numeroElegido = Numero[NumeroAleatorio];
            Console.WriteLine("Tu nave es" + nombreElegido + "-" + numeroElegido);
            break;

            case 2: // CAMBIAR NOMBRE
                Console.WriteLine("Has elegido la opción 2");
Console.WriteLine($"el nombre de tu nave es {nombreElegido}, quieres cambiar el nombre?");
if (true)
{
    
}
                break;

            case 3: // LISTAR NAVES
                Console.WriteLine("Has elegido la opción 3");

                break;
            case 4: // BORRARLAS
                Console.WriteLine("Has elegido salir de la aplicación");
                salir = true;
                break;
            default: // SALIR
                Console.WriteLine("Elige una opcion entre 1 y 4");
                break;
        }
    }

}



