using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class ClientesSinReistro :Cliente , ICliente
    {
        public int Decsuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public decimal CalcularDescuento()
        {
            return Descuento;
        }
    }
}
