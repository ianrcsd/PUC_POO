﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ian_Veiculos
{
    class Veiculos
    {
        //Constantes para consumo de de combustivel po litro - KM e reserva - litros
        private const int consumoAlcool = 7;
        private const int consumoGasolina = 10;
        private const int reserva = 5;


        private int capacidadeTanque;
        private double distancia;
        private char tipoCombustivel;
        private double totTanque;
        private double litros;

        public double getTottanque()
        {
            return this.totTanque;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">Se G - Gasolina / A - Alcool</param>
        public void setTipoCombustivel(char t)
        {
            this.tipoCombustivel = t;
        }

        public void setDistancia(double d)
        {
            this.distancia = d;
        }

        public int getCapacidadeTanque()
        {
            return this.capacidadeTanque;
        }

        /// <summary>
        /// mÉtodo para fazer a capacidade do tanque
        /// </summary>
        /// <param name="capacidade">Capacidade toal do tanque, tem que ser entre 40 e 50 litros</param>
        public void setCapacidadeTanque(int capacidade)
        {            
            if (capacidade > 40 && capacidade < 50)
            {
                this.capacidadeTanque = capacidade;
            }
        }

        /// <summary>
        /// Metodo para encher o tanque
        /// </summary>
        /// <returns></returns>
        public double Reabastecer()
        {
            int cont = 0;
            while (this.capacidadeTanque < this.totTanque)
            {
                this.totTanque++;
                cont++;
            }
            return cont;
        }


        public void TrechoPercorrido(double distancia)
        {
            this.distancia = distancia;
            double qdtLitros = 0;
            if (this.tipoCombustivel == 'G')
            {
                qdtLitros = distancia * consumoGasolina;
            }
            else
            {
                qdtLitros = distancia * consumoAlcool;
            }            
        }


        public bool AvisoReserva()
        {
            if (totTanque < reserva)
            {
                return true;
            }
            else
                return false;
        }

    }
}
