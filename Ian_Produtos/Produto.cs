using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ian_Produtos
{
    class Produto
    {
        //constantes privadas referente a porcentagem de impostos
        private const double impBebida = 0.33;
        private const double impComida = 0.18;
        private const double impMaterialLimpeza = 0.25;
        private const double porcentLucro = 1.25;

        private int categoria;
        private double valorCusto;
        private double valorSemImposto;
        private double valorTotal;
        private double valorLucro;
        private double imposto;

        public int getCategoria()
        {
            return this.categoria;
        }   
        
        public double getValorSemImposto()
        {
            return this.valorSemImposto;
        }

        public void ValorSemImposto()
        {
            this.valorSemImposto = this.valorTotal - this.imposto; 
        }
        public void setCategoria(int c)
        {
            this.categoria = c;            
        }


        public double getValorCusto()
        {
            return this.valorCusto;
        }

        public void setValorCusto(double vc)
        {
            this.valorCusto = vc;
            Imposto();
        }


        public double getValorTotal()
        {
            return this.valorTotal;
        }

        public void ValorTotal()
        {
            this.valorTotal = (this.valorCusto + imposto)* porcentLucro;
        }

        public double getValorLucro()
        {
            return this.valorLucro;
        }

        public void ValorLucro()
        {
            this.valorLucro = this.valorTotal - this.valorCusto - this.imposto;       
        }


        public void Imposto()
        {
            if (this.categoria == 1)
                this.imposto = impBebida * this.valorCusto;
            else if (this.categoria == 2)
                this.imposto = impComida * this.valorCusto;
            else
                this.imposto = impMaterialLimpeza * this.valorCusto;
        }

        public void CalualrPreco()
        {
            ValorTotal();
            ValorSemImposto();
            ValorLucro();
           
        }
        

    }
}
