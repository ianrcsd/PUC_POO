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
            Console.WriteLine("Digite a capacidade do Tanque");
            int capTanque = int.Parse(Console.ReadLine());

            Veiculos v = new Veiculos(capTanque);

            char opc;

            do
            {
                Console.WriteLine("\nSeu Carro esta com {0} Litros", v.getTottanque());               



                if (v.AvisoReserva())
                {
                    Console.WriteLine("Digite se o Veículo e alcool (A) ou gasolina (G):\nOu X para Sair ");
                    opc = char.Parse(Console.ReadLine());
                    v.setTipoCombustivel(opc);
                    Console.WriteLine("É necessário Reabastecer, Tanque com menos de 5 Litros");
                    Console.WriteLine("\nVoce gostaria de reabastecer, Digite S para Sim ou N para Não ");
                    opc = char.Parse(Console.ReadLine());
                    if (opc == 'S')
                    {
                        v.Reabastecer();
                    }
                }
                else
                {
                    Console.WriteLine("Digite a distancia percorrida");
                    double km = double.Parse(Console.ReadLine());
                    v.TrechoPercorrido(km);
                    Console.WriteLine("A quantidade de Litros gastos foram: {0}", v.getQtdLitros());
                    Console.WriteLine();
                }
                Console.Clear();

                Console.WriteLine("Digite C para Continuar ou X para sair");
                opc = Console.ReadKey().KeyChar;               


            } while (opc != 'X');


        }
    }
}
