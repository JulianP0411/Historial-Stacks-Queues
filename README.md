# Simulación de un Historial de Navegación con Stacks y Queues

### Descripción
Este proyecto es una simulación de un historial de navegación utilizando Stack<T> y Queue<T> en C#. Permite al usuario visitar nuevas páginas, retroceder en la navegación y gestionar páginas en espera.

### Tecnología Utilizada
- Editor de codigo: Visual Studio 2022
- Lenguaje: C#
- Funciones implementadas: Stack y Queue

### Instrucciones de Uso
- Compila y ejecuta el programa.
- Usa los números del 1 al 5 para seleccionar las diferentes opciones del programa.

### Funcionalidades
- Visitar una nueva página: Guarda la página visitada en el historial.
```
case '1': // Visitar nueva página
    Console.Write("Ingresa la URL de la nueva página: ");
    string nuevaPagina = Console.ReadLine() ?? "Página Desconocida";

    if (!string.IsNullOrWhiteSpace(nuevaPagina))
    {
        historial.Push(paginaActual); // Guarda la página al historial
        paginaActual = nuevaPagina;
    }
    break;
```
- Retroceder: Usa ***<ins>Stack</ins>*** para regresar a la pagina anterior.
```
case '2': // Retroceder
    if (historial.Count > 0)
    {
        paginaActual = historial.Pop();
    }
    else
    {
        Console.WriteLine("No hay páginas anteriores.");
        Console.ReadKey();
    }
    break;
```
- Agregar página a cola de espera: Usa ***<ins>Queue</ins>*** para añadir la página a la cola de espera.
```
case '3': // Agrega página en espera
    Console.Write("Ingresa la URL de la página en espera: ");
    string paginaEspera = Console.ReadLine() ?? "Página Desconocida";

    if (!string.IsNullOrWhiteSpace(paginaEspera))
    {
        enEspera.Enqueue(paginaEspera);
    }
    break;
```
- Visitar página en la cola de espera: Muestra la página añadida a la cola de espera.
```
case '4': // Visita la página en espera
    if (enEspera.Count > 0)
    {
        historial.Push(paginaActual); // Guarda la página actual
        paginaActual = enEspera.Dequeue();
    }
    else
    {
        Console.WriteLine("No hay páginas en espera.");
        Console.ReadKey();
    }
    break;
```
