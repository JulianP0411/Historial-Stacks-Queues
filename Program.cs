using System;

namespace GestorDeCalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos el número de estudiantes
            int numEstudiantes;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            numEstudiantes = int.Parse(Console.ReadLine());

            // Arrays para almacenar los nombres y calificaciones
            string[] nombres = new string[numEstudiantes];
            double[] calificaciones = new double[numEstudiantes];

            // Ingresamos los nombres y las calificaciones
            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine($"Estudiante #{i + 1}:");
                Console.Write("Ingrese el nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese la calificación: ");
                calificaciones[i] = double.Parse(Console.ReadLine());
            }

            // Mostrar el menú de opciones
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Gestor de Calificaciones Estudiantiles");
                Console.WriteLine("1. Calcular Promedio por Estudiante");
                Console.WriteLine("2. Calcular Promedio del Grupo");
                Console.WriteLine("3. Buscar Estudiante por Nombre");
                Console.WriteLine("4. Mostrar Estudiantes por Encima del Promedio");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularPromedioPorEstudiante(nombres, calificaciones);
                        break;
                    case 2:
                        CalcularPromedioGrupo(calificaciones);
                        break;
                    case 3:
                        BuscarEstudiante(nombres, calificaciones);
                        break;
                    case 4:
                        MostrarEstudiantesPorEncimaDelPromedio(calificaciones, nombres);
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
                if (continuar)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // Calcular promedio por estudiante
        static void CalcularPromedioPorEstudiante(string[] nombres, double[] calificaciones)
        {
            Console.WriteLine("Promedio por Estudiante:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Estudiante: {nombres[i]}, Promedio: {calificaciones[i]}");
            }
        }

        // Calcular promedio del grupo
        static void CalcularPromedioGrupo(double[] calificaciones)
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedioGrupo = suma / calificaciones.Length;
            Console.WriteLine($"Promedio del Grupo: {promedioGrupo}");
        }

        // Buscar estudiante por nombre
        static void BuscarEstudiante(string[] nombres, double[] calificaciones)
        {
            Console.Write("Ingrese el nombre del estudiante a buscar: ");
            string nombreBusqueda = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower() == nombreBusqueda.ToLower())
                {
                    Console.WriteLine($"Estudiante encontrado: {nombres[i]}, Calificación: {calificaciones[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }

        // Mostrar estudiantes con calificaciones por encima del promedio
        static void MostrarEstudiantesPorEncimaDelPromedio(double[] calificaciones, string[] nombres)
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedioGrupo = suma / calificaciones.Length;

            Console.WriteLine($"Promedio del Grupo: {promedioGrupo}");
            Console.WriteLine("Estudiantes con calificaciones por encima del promedio:");

            bool hayEstudiantesEncimaDelPromedio = false;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] > promedioGrupo)
                {
                    Console.WriteLine($"Estudiante: {nombres[i]}, Calificación: {calificaciones[i]}");
                    hayEstudiantesEncimaDelPromedio = true;
                }
            }

            if (!hayEstudiantesEncimaDelPromedio)
            {
                Console.WriteLine("No hay estudiantes con calificaciones por encima del promedio.");
            }
        }
    }
}