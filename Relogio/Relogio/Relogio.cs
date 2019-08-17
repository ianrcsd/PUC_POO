using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relogio
{
    class Relogio
    {

        public int hora;
        public int minuto;
        public int segundo;
        public int dia;
        public int mes;

        public void AjusteHora(int h, int m)
        {
            this.hora = h;
            this.minuto = m;
            
        }

        public void AjusteData(int d, int m)
        {
            this.dia = d;
            this.mes = m;
        }

        public void Renicializar()
        {
            hora = minuto = segundo = 0;
            dia = mes = 01;
        }

        public void PassarTempo()
        {
            int maxQtdSegundo = 59, maxQtdMin = 59, maxQtdHora = 24, maxQtdDia = 30, maxQtdMes = 12;

            this.segundo++;
            if (this.segundo == maxQtdSegundo)
            {
                this.segundo = 0;
                this.minuto++;

                if (this.minuto == maxQtdMin)
                {
                    this.minuto = 0;
                    this.hora++;

                    if (this.hora == maxQtdHora)
                    {
                        this.hora = 0;
                        this.dia++;

                        if (this.dia == maxQtdDia)
                        {
                            this.dia = 0;
                            this.mes++;

                            if (this.mes == maxQtdMes)
                            {
                                this.mes = 0;
                            }

                        }
                    }
                }
            }
        }

        
    }
}
