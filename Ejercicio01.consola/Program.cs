using System.ComponentModel.Design;

namespace Ejercicio01.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese la base del paralelogramo: ");
                var Base = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del paralelogramo: ");
                var altura = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado del paralelogramo: ");
                var lado = double.Parse(Console.ReadLine());

                if (Base > 0)
                {
                    var perimetro = 2 * (Base + lado);
                    var superficie = Base * altura;
                    Console.WriteLine($"Paralelogramo de base {Base} , altura {altura} , y lado {lado} tiene una superficie de {superficie} y un perimetro de {perimetro}.");

                }

                if (altura > 0)
                    {
                        var perimetro = 2 * (Base + lado);
                        var superficie = Base * altura;
                    Console.WriteLine($"Paralelogramo de base {Base} , altura {altura} , y lado {lado} tiene una superficie de {superficie} y un perimetro de {perimetro}.");

                }

                if    (lado > 0)
                    {
                    var perimetro = 2 * (Base + lado);
                    var superficie = Base * altura;
                    Console.WriteLine($"Paralelogramo de base {Base} , altura {altura} , y lado {lado} tiene una superficie de {superficie} y un perimetro de {perimetro}.");
                }
                        else
                       Console.WriteLine("Se deben ingresar un numeros mayores a cero!!!");
                
            }
            catch (Exception)
            {

                Console.WriteLine("Algo salió mal!!!");
            }
        }
    }
}
