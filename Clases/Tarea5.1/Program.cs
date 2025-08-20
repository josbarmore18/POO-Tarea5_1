using System;

namespace Tarea5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora de Salario ===");

            Console.Write("Nombre del empleado: ");
            string nombre = Console.ReadLine() ?? "";

            var persona = new Persona(nombre);
            var marcador = new Marcador();

            Console.Write("Horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Pago por hora: ");
            double pago = double.Parse(Console.ReadLine() ?? "0");

            double salario = marcador.CalcularSalario(horas, pago);

            Console.WriteLine($"\nEmpleado: {persona.Nombre}");
            Console.WriteLine($"Salario: {salario:0.00}");

            Console.WriteLine("\nPulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}