using System;

class Program
{
    static void Main(string[] args)
    {
        // PARTE I: Realizar la declaración y asignación de valores.
        // Declarar variables de tipo texto y capturar valores desde la consola.
        Console.Write("Ingrese el Departamento: ");
        string? departamento = Console.ReadLine();

        Console.Write("Ingrese el Municipio: ");
        string? municipio = Console.ReadLine();

        Console.Write("Ingrese la Ciudad: ");
        string? ciudad = Console.ReadLine();

        // Declarar y asignar valores a variables de texto.
        string? colonia = "Santa Maria";
        string? colorCasa = "Rojo";

        // Declarar y asignar valores a variables enteras desde consola.
        int añosResidencia = 8;
        int edadActual = 28;

        // Declarar y asignar valores a variables DateTime.
        DateTime fechaNacimiento = new DateTime(1995, 04, 01); 
        DateTime fechaActual = DateTime.Now;

        // PARTE II: Realizar el proceso de asignación de funciones.
        // Aplicar funciones a variables de tipo texto.
        bool comparacion = ciudad == municipio;
        string? textoConcatenado = departamento + " - " + municipio + " - " + ciudad;
        string? mayusculaColonia = colonia.ToUpper();
        string? minusculaColonia = colonia.ToLower();
        string? cadenaLimpia = colorCasa.Trim();
        int longitudColonia = colonia.Length;
        int longitudColorCasa = colorCasa.Length;

        // Mostrar resultados.
        Console.WriteLine("************************Imprimiendo Datos**********************");
        Console.WriteLine("Variables tipo texto: " + colonia + ", " + colorCasa);
        Console.WriteLine("Comparación de cadenas: " + comparacion + " " + ciudad + ", " + municipio);
        Console.WriteLine("Impresion de variables tipo entero: " + añosResidencia + " años de residencia");
        Console.WriteLine("Impresion de variable tipo entero: " + edadActual + " años de edad");
        Console.WriteLine("Texto concatenado: " + textoConcatenado);
        Console.WriteLine("Funcion texto a mayúscula: " + mayusculaColonia);
        Console.WriteLine("Funcoion minuscula: " + minusculaColonia);
        Console.WriteLine("Funcion Cadena limpia: " + cadenaLimpia);
        Console.WriteLine("Longitud de la Colonia: " + longitudColonia);
        Console.WriteLine("Variable tipo date para DOB: " + fechaNacimiento);
        Console.WriteLine("Variable tipo date: " + fechaActual);
        Console.WriteLine("Longitud del Color de Casa: " + longitudColorCasa);
        Console.WriteLine("************************Imprimiendo Datos**********************");

        // Esperar a que el usuario presione una tecla para salir.
        Console.ReadKey();
    }
}
