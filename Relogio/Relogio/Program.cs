using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relogio
{
    class Program
    {
        
        public static void Menu (Relogio rlg)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Digite:");
            Console.WriteLine("1 -  Passar tempo");
            Console.WriteLine("2 -  Ajustar Data");
            Console.WriteLine("3 -  Ajustar Hora");
            Console.WriteLine("4 -  Reiniciar");
            Console.WriteLine("5 -  Sair");
            Console.WriteLine("=================================================");
            Console.WriteLine("Agora são {0}h:{1}m:{2}s e a Data é {3}/{4}", rlg.hora, rlg.minuto, rlg.segundo, rlg.dia, rlg.mes);
        }

        public static int LerOpcao()
        {            
            int opc;
            return opc = int.Parse(Console.ReadLine());           
        }

       

        public static void Acao(int opc, Relogio rlg)
        {           

            switch (opc)
            {
                case 1:
                    rlg.PassarTempo();
                    break;
                case 2:
                    Console.WriteLine("Digite a Data");                    
                    int d = LerOpcao();
                    Console.WriteLine("Digite o Mês");
                    int mes = LerOpcao();
                    rlg.AjusteData(d,mes);
                    break;
                case 3:
                    Console.WriteLine("Digite a Hora");
                    int h = LerOpcao();
                    Console.WriteLine("Digite o Minuto");
                    int min = LerOpcao();                    
                    rlg.AjusteHora(h,min);                    
                    break;
                case 4:
                    rlg.Renicializar();
                    break;                
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            Relogio rlg = new Relogio();
            do
            {
                Console.Clear();             
                Menu(rlg);
                int opc = LerOpcao();
                Acao(opc,rlg);                
            } while (true);
            
        }
    }
}
