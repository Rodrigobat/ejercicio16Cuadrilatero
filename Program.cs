using System;
namespace EjercicioClase16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prueba=new Trapecio();
            Console.WriteLine($"el area es {prueba.calcularArea()}");
        }
    }
}