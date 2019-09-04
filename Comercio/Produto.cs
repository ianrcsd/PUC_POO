using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    class Produto
    {
        //constantes privadas referente a porcentagem de impostos
        private const double impBebida = 0.33;
        private const double impComida = 0.18;
        private const double impMaterialLimpeza = 0.25;

        private double vlrProdutoCusto;
        private double vlrProdutoTotal;
        private double vlrLucroProduto;
        private int tipoProduto;

        public double getValorCustoProduto()
        {
            return vlrProdutoCusto;
        }
        public double getValorProduto()
        {
            return vlrProdutoTotal;
        }
        public double getLucro()
        {
            return vlrLucroProduto;
        }



    }
}
