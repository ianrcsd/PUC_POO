using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao
{
    class Program
    {
        public static void Menu(Tv t)
        {
            Console.WriteLine("Sua TV está {0}", StatusTv(t));
            if (t.ligada)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Digite:");
                Console.WriteLine("1 - Desligar TV");
                Console.WriteLine("2 - Aumentar Volume");
                Console.WriteLine("3 - Diminuir Volume");
                Console.WriteLine("4 - Troca de Canal");
                Console.WriteLine("===============================");
            }
            else
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Digite:");
                Console.WriteLine("1 - Ligar TV");                
                Console.WriteLine("===============================");
            }
               
        }

        // Esse método deveria ficar na classe ou no programa
        public static string StatusTv(Tv t)
        {
            if (t.ligada)
                return "Ligada";
            else
                return "Desligada";
        }

        public static int LerOpcao()
        {
            int opc;
            return opc = int.Parse(Console.ReadLine());
        }       

        public static void Acao(int opc, Tv t)
        {
            if (t.ligada)
            {
                switch (opc)
                {
                    case 1:
                        t.ligada = false;
                        break;
                    case 2:
                        t.AumentaVolume();
                        break;
                    case 3:
                        t.DiminuiVolume();
                        break;
                    case 4:
                        Console.WriteLine("Digite o canal");
                        int c = LerOpcao();
                        t.MudaCanal(c);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (opc)
                {
                    case 1:
                        t.ligada = true;
                        break;                    
                    default:
                        break;
                }
            }
           
        }

        static void Main(string[] args)
        {
            Tv tv = new Tv();
            do
            {
                Console.Clear();
                Menu(tv);
                int opc = LerOpcao();
                Acao(opc, tv);
            } while (true);



        }
    }
}
