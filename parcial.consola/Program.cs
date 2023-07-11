using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace parcial.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double area;
            double volumen;
            double h;
            double base1;
            double radio;
            int CantidadDeCilindros=0;
            bool seguir = true;
            do
            {
               h=Pedirdoublex("Ingrese la altura del cilindro");
                radio = Pedirdoublex("ingresar el radio del cilindro");
                if (h != 0);
                area = CalcularArea(h, radio);
                base1 = CalcularBase(radio);
                volumen = CalcularVolumen(h, area);
                CantidadDeCilindros = CantidadDeCilindros + 1;
                if (radio != 0)
                {
                    area = CalcularArea(h, radio);
                    base1 = CalcularBase(radio);
                    volumen = CalcularVolumen(h, area);
                    CantidadDeCilindros = CantidadDeCilindros + 1;
                }
                else
                {
                    seguir = false;
                }
            






            } while (seguir);
            Console.WriteLine($"La cantidad ingresada fue: {CantidadDeCilindros}");

        }

        private static double CalcularVolumen(double h, double base1)
        {
            return base1 * h;
        }

        private static double CalcularBase(double radio)
        {
            return Math.PI *Math.Pow( radio, 2);
        }

        private static double CalcularArea(double h, double radio)
        {
            return 2 *Math.PI * radio * (h + radio);
        }

        private static double Pedirdoublex(string mensaje)
        {
            double nro = 0;
            do
            {
                Console.Write(mensaje);
                String Strconsola = (Console.ReadLine());
                if (!double.TryParse(Strconsola, out nro))
                {
                    Console.WriteLine("numero ingresado incorrecto");
                }
                else 

                {
                    break;
                }
                
            } while (true);
            return nro;
        }
    }
}