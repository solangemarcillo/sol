using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    interface ICliente
    {
        /* aqui se crea la interfaz de la clase padre 
         * el cual heredara a sus hijas
         */

        public int Decsuento { get; set; }    
        decimal CalcularDescuento();  
    }
}
