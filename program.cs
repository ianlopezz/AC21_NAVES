

string[] naves = new string[5];
bool salir = false;
int contadorNaves = 0;



while (!salir)
{
    string nombreElegido = "";
    int numeroElegido = 0;
    string finalName = "";

    Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
    Console.WriteLine("1. Crear una nave");
    Console.WriteLine("2. Cambiar el nombre de la nave");
    Console.WriteLine("3. Listar todas las naves");
    Console.WriteLine("4. Eliminar todas las naves");
    Console.WriteLine("5. Salir del menú");
    int opcion = Convert.ToInt32(Console.ReadLine());

    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
    {
        Console.WriteLine("Opción inválida. Intenta de nuevo (1-5):");
    }


    switch (opcion)
    {
        case 1: // CREAR
            Console.WriteLine("Has elegido la opción 1");

            string[] Nombres = { "HALCONMILNEARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING" };
            Random generador = new Random();
            int indiceAleatorio = generador.Next(Nombres.Length);
            nombreElegido = Nombres[indiceAleatorio];

            numeroElegido = generador.Next(10, 100);
            Console.WriteLine();
            Console.WriteLine("✓ Nave Creada:" + nombreElegido + "-" + numeroElegido);
            Console.WriteLine();

            finalName = nombreElegido + "-" + numeroElegido;

            if (contadorNaves < naves.Length)
            {
                naves[contadorNaves] = finalName;
                contadorNaves++;
            }
            else
            {
                Console.WriteLine("No se pueden crear más naves. El espacio está lleno.");
            }

            break;

        case 2: // CAMBIAR NOMBRE
            Console.WriteLine("Has elegido la opción 2");
            Console.WriteLine($"¿Quieres cambiar el nombre (s/n)?");
            string respuesta = Console.ReadLine() ?? "";

            if (respuesta == "s" || respuesta == "S")
            {
                Console.Write($"✓ Nave renombrada: {finalName}");
            }

            break;

        case 3: // LISTAR NAVES
            Console.WriteLine("Has elegido la opción 3");
            Console.WriteLine($"=== NAVES FABRICADAS ===");

            if (contadorNaves > 0)
            {
                for (int i = 0; i < contadorNaves; i++)
                {
                    Console.WriteLine($"{i + 1}. {naves[i]}");
                }
            }
            else
            {
                Console.WriteLine("No hay naves creadas.");
            }

            Console.WriteLine();
            break;

        case 4: // BORRAR UNA O TODAS
            Console.WriteLine("Quieres borrar tu nave, (s/n)?");
            bool respuestaBorrar = ObtenerRespuestaSiNo();
            if (respuestaBorrar)
            {
                // Lógica de eliminación
                Array.Clear(naves, 0, naves.Length); // Esto borra todas las naves
                contadorNaves = 0; // Reinicia el contador
                Console.WriteLine("Todas las naves han sido eliminadas.");
            }
            else
            {
                // No borrar
            }
            break;

        case 5: // SALIR
            Console.WriteLine("Has elegido salir de la aplicación");
            if (salir)
            {
                Console.WriteLine("Programa finalizado.");
            }
            salir = true;
            break;

        default: // SALIR
            Console.WriteLine("Elige una opcion entre 1 y 4");
            
            break;
    }
    
}


static bool ObtenerRespuestaSiNo()
{
    string respuesta = Console.ReadLine()?.ToLower() ?? "";
    while (respuesta != "s" && respuesta != "n")
    {
        Console.WriteLine("Por favor, ingresa 's' para sí o 'n' para no.");
        respuesta = Console.ReadLine()?.ToLower() ?? "";
    }
    return respuesta == "s";
}