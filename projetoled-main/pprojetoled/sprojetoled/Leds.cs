using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprojetoled
{
    internal class Leds
    {
        private byte estado;

        public Leds()
        {
            this.estado = 0;
        }
        public Leds(byte estado)
        {
            this.estado = estado;
        }
        public void acender(int led)
        {
            this.estado = (byte)((int)this.estado | (int)Math.Pow(2, led - 1));
        }
        public void apagar(int led)
        {
            this.estado = (byte)((int)this.estado & (int)(255 - Math.Pow(2, led - 1)));
        }
        public bool getEstado(int led)
        {
            byte aux;
            aux = (byte)((int)this.estado & (int)Math.Pow(2, led - 1));
            return aux > 0;

        }
    }
}
