using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientePremiun: Cliente , ICliente
    {
       public int Decsuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // Aqui se esta implementando la interfaz ICliente

       
        public decimal CalcularDescuento()
        {
            return 0;
        }
    }
}

