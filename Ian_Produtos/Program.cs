using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ian_Produtos
{
    class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha o Tipo do Produto");
            Console.WriteLine("1 - Bebida");
            Console.WriteLine("2 - Comida");
            Console.WriteLine("3 - Material de Limpeza");
            Console.WriteLine("4 - Sair");
        }

        static void Resultado(Produto p)
        {
            Console.Clear();
            Console.WriteLine("O preço do produto sem imposto é: {0}", p.getValorSemImposto().ToString("C"));
            Console.WriteLine("O preço de venda do Produto é: {0}", p.getValorTotal().ToString("C"));
            Console.WriteLine("O Lucro do produto é: {0}", p.getValorLucro().ToString("C"));
        }
        static void Main(string[] args)
        {
            Produto prod = new Produto();            

            int tipo = 0;
            do
            {                
                Menu();
                tipo = int.Parse(Console.ReadLine());
                prod.setCategoria(tipo);
                Console.WriteLine("Digite o valor de Custo do Produto");
                double valorCusto = double.Parse(Console.ReadLine());
                prod.setValorCusto(valorCusto);
                prod.CalualrPreco();               
                Resultado(prod);

                Console.ReadKey();

            } while (tipo != 4);




        }
    }
}
