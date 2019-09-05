using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ian_Veiculos
{
    class Program
    {

        static void Main(string[] args)
        {
            Veiculos v = new Veiculos();

            char opc;
            do
            {
                Console.WriteLine("\nSeu Carro esta com {0} Litros", v.getTottanque());
                if (v.AvisoReserva())
                {
                    Console.WriteLine("É necessário Reabastecer, Tanque com menos de 5 Litros");
                }                
                Console.WriteLine("Digite se o Veículo e alcool (A) ou gasolina (G):\nOu X para Sair ");                
                opc = char.Parse(Console.ReadLine());
                v.setTipoCombustivel(opc);
                Console.WriteLine("Digite a distancia percorrida");
                double km = double.Parse(Console.ReadLine());
                v.TrechoPercorrido(km);
                Console.WriteLine();



            }while (opc != 'X');


        }
    }
}
