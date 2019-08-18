using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao
{
    class Tv
    {
        public bool ligada;
        public int canal = 2;
        public int volume = 95;

        public bool LigaDesliga(bool tipo)
        {
            this.ligada = tipo;
            if (ligada)
                return true;
            else
                return false;
        }      

        public bool MudaCanal(int c)
        {            
            if (c > 2 && c < 85)
            {
                this.canal = c;
                return true;
            }
            else
                return false;
        }

        public bool AumentaVolume()
        {
            if (this.volume == 100)            
                return false;            
            else
            {
                this.volume = this.volume + 1;
                return true;
            }
        }

        public bool DiminuiVolume()
        {
            if (this.volume == 2)
                return false;
            else
            {
                this.volume = this.volume - 1;
                return true;
            }
        }

        //Qual seria melhor, criar 2 métodos para aumentar e diminur o volume ou apenas um?
        /*public bool MudaVolume(int v)
        {            
            if (v > 2 && v < 85)
            {
                this.volume = v;
                return true;
            }
            else
                return false;
        }*/

    }
}
