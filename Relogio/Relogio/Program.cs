using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relogio
{
    class Program
    {
        
        public static void Menu ()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Digite:");
            Console.WriteLine("1 -  Passar tempo");
            Console.WriteLine("2 -  Ajustar Data");
            Console.WriteLine("3 -  Ajustar Hora");
            Console.WriteLine("4 -  Reiniciar");
            Console.WriteLine("5 -  Mostra Tempo");
            Console.WriteLine("6 -  Sair");
            Console.WriteLine("=================================================");

        }

        public static int LerOpcao()
        {            
            int opc;
            return opc = int.Parse(Console.ReadLine());           
        }

        public static void Acao(int opc)
        {
            Relogio rlg = new Relogio();

            switch (opc)
            {
                case 1:
                    rlg.PassarTempo();
                    break;
                case 2:
                    Console.WriteLine("")
                    break;
                default:
                    break;
            }
        }

        
        static void Main(string[] args)
        {
            

            Menu();


        }
    }
}
