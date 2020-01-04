using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class  ClientesRegistrado: Cliente , ICliente
    {
       

        public int Telefono { get; set; }

        public DateTime FechadeAfilacion { get; set; }

        public DateTime FecadeFinalizacionAfi { get; set; }


        public int Decsuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // Aqui se esta implementando la interfaz ICliente

        public decimal CalcularDescuento()
        {
            return 0;
        }
    }
}
