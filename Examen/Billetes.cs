using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenNS
{
    /// <summary>
    /// Clase que calcula el número de billetes de 50, de 20 y de 10, de una cantidad
    /// </summary>
    public class Billetes
    {
        public const string NoMultiplo10 = "La cantidad ha de ser multiplo de 10";
        public const string NumeroNegativo = "La cantidad no puede ser negativa";
        private int billetes50;
        private int billetes20;
        private int billetes10;

        public int Billetes50 { get => billetes50; set => billetes50 = value; }
        public int Billetes20 { get => billetes20; set => billetes20 = value; }
        public int Billetes10 { get => billetes10; set => billetes10 = value; }

        /// <summary>
        /// Se inicializan las variables a 0
        /// </summary>
        public Billetes()
        {
            Billetes50 = 0;
            Billetes20 = 0;
            Billetes10 = 0;
        }

        /// <summary>
        /// Método que calcula el número de billetes
        /// </summary>
        /// <remarks>De la cantidad incial calcula los billetes de 50<see cref=">Billetes50"/> los billetes de 20 <see cref=">Billetes20
        /// "/> y los billetes de 10<see cref=">Billetes10"/> de la cantidad introducida</remarks>
        /// <param name="cantidad">Cantidad introducida por el usuario</param>
        /// <exception cref="ArgumentOutOfRangeException">Salta la excepcion cuando la cantidad no es múltiplo de 10</exception>
        public void EstablecerCantidad(int cantidad)
        {
            
            if ((cantidad % 10) != 0)
            {
                throw new ArgumentOutOfRangeException("cantidad", cantidad, NoMultiplo10);
            }
               
            if (cantidad < 0)
            {
                throw new Exception(NumeroNegativo);
            }
                
            if ((cantidad >= 50))
            {
                Billetes50 = (cantidad / 50);
                cantidad = cantidad - (Billetes50 * 50);
            }

            if ((cantidad >= 20))
            {
                Billetes20 = (cantidad / 20);
                cantidad = cantidad - (Billetes20 * 20);
            }

            if ((cantidad >= 10))
            {
                Billetes10 = (cantidad / 10);
                cantidad = cantidad - (Billetes10 * 10);
            }
        }
    }
}
