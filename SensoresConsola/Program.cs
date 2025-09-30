using System;

class Program
{

    public static bool salir = false;
    public static int[][] arraySensores;

    static void Main()
    {
        int numSensores = -1;
        bool valido = false;
        string input = String.Empty;

        do
        {
            Console.Write("Escriba el número de sensores: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out numSensores) && numSensores > 0)
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ser un número entero mayor que 0.");
            }

        } while (!valido);

        arraySensores = new int[numSensores][];

        valido = false;
        input = String.Empty;

        for (int i = 0; i < numSensores; i++)
        {
            int numMedidas = -1;
            do
            {
                Console.Write($"Número de medidas del sensor {i + 1}: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out numMedidas) && numMedidas > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debe ser un número entero mayor que 0.");
                }
            } while (!valido);

            arraySensores[i] = new int[numMedidas];
        }

        Random rnd = new Random();

        // Rellenar array
        for (int i = 0; i < arraySensores.Length; i++)
        {
            for (int j = 0; j < arraySensores[i].Length; j++)
            {
                arraySensores[i][j] = rnd.Next(0, 101);
            }
        }

        //Mostrar menu
        do
        {
            mostrarMenu();

        } while (salir != true);
    }

    public static void mostrarMenu()
    {
        int sensorSeleccionado = -1;
        int opcion = -1;
        bool valido = false;
        string input = String.Empty;

        Console.Clear();
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Mostrar todas las medidas de todos los sensores.");
        Console.WriteLine("2. Mostrar las medidas de un sensor.");
        Console.WriteLine("3. Mostrar la media de las medidas de un sensor.");
        Console.WriteLine("4. Mostrar la media de las medidas de todos los sensores.");
        Console.WriteLine("5. Salir.");
        Console.Write("Seleccione una opción: ");

        input = Console.ReadLine();
        if (int.TryParse(input, out opcion) && opcion >= 1 && opcion <= 5)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Escriba un número de opción válido.");
        }

        switch (opcion)
        {
            case 1:
                mostrarMedidasTodosSensores();
                esperar();
                break;
            case 2:
                sensorSeleccionado = -1;
                valido = false;
                do
                {
                    Console.Write("Seleccione el sensor: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out sensorSeleccionado) &&
                        sensorSeleccionado >= 1 && sensorSeleccionado <= arraySensores.Length)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Escriba un número de sensor válido.");
                    }

                } while (!valido);
                mostrarMedidasUnSensor(sensorSeleccionado - 1);
                esperar();
                break;
            case 3:
                sensorSeleccionado = -1;
                valido = false;
                do
                {
                    Console.Write("Seleccione el sensor: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out sensorSeleccionado) &&
                        sensorSeleccionado >= 1 && sensorSeleccionado <= arraySensores.Length)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Escriba un número de sensor válido.");
                    }

                } while (!valido);
                mostrarMediaUnSensor(sensorSeleccionado - 1);
                esperar();
                break;
            case 4:
                mostrarMediasTodosSensores();
                esperar();
                break;
            case 5:
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }
    }

    public static void mostrarMedidasTodosSensores()
    {
        for (int i = 0; i < arraySensores.Length; i++)
        {
            Console.Write($"Sensor {i + 1}: ");
            for (int j = 0; j < arraySensores[i].Length; j++)
            {
                Console.Write(arraySensores[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void mostrarMedidasUnSensor(int sensor)
    {
        Console.Write($"Sensor {sensor + 1}: ");
        for (int j = 0; j < arraySensores[sensor].Length; j++)
        {
            Console.Write(arraySensores[sensor][j] + " ");
        }
        Console.WriteLine();
    }

    public static void mostrarMediaUnSensor(int sensor)
    {
        int suma = 0;
        for (int i = 0; i < arraySensores[sensor].Length; i++)
        {
            suma += arraySensores[sensor][i];
        }
        double media = (double)suma / arraySensores[sensor].Length;
        Console.WriteLine($"La media del sensor {sensor + 1} es: {media}");
    }

    public static void mostrarMediasTodosSensores()
    {
        for (int i = 0; i < arraySensores.Length; i++)
        {
            int suma = 0;
            for (int j = 0; j < arraySensores[i].Length; j++)
            {
                suma += arraySensores[i][j];
            }
            double media = (double)suma / arraySensores[i].Length;
            Console.WriteLine($"La media del sensor {i + 1} es: {media}");
        }
    }

    public static void esperar()
    {
        Console.WriteLine("Pulse una tecla para continuar...");
        Console.ReadKey();
    }

}

