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
                break;

            case 2: // CAMBIAR NOMBRE
                Console.WriteLine("Has elegido la opción 2");
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