namespace Ejercicio02.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayorSuperficie = 0;
            int interaccion = 0;
            double promediosuperficie = 0;
            int Base;
            int Altura;
            int Lado, perimetro, superficie;
            for (int i = 0; i < 5; i++)
            {

                do
                {
                    Console.Write("Ingrese la base del paralelogramo: ");

                    Base = int.Parse(Console.ReadLine());

                    if (Base > 0)
                        break;
                    else
                    {
                        Console.WriteLine("Base mal ingresada!!!");

                    }
                }
                while (true);
                do
                {
                    Console.Write("Ingrese la altura del paralelogramo: ");
                    Altura = int.Parse(Console.ReadLine());
                    if (Altura > 0)
                        break;
                    Console.WriteLine("Altura mal ingresada!!!");

                } while (true);
                do
                {
                    Console.Write("Ingrese el lado del paralelogramo: ");
                    Lado = int.Parse(Console.ReadLine());
                    if (Lado > 0)
                        break;
                    Console.WriteLine("Lado mal ingresado!!!");
                }
                while (true);
                perimetro = 2 * (Base + Lado);
                superficie = Base * Altura;
                Console.WriteLine($"Paralelogramo de base {Base} , altura {Altura} , y lado {Lado} tiene una superficie de {superficie} y un perimetro de {perimetro}.");

                promediosuperficie = superficie / 5;
                if {
                    mayorSuperficie > promediosuperficie; 
                    



            }
        }
    }
}

