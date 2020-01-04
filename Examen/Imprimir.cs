using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class  Imprimir
    {
        
        public Imprimir()
        {
            ListaClientes = new List<Cliente>();
        }


        public List<Cliente> ListaClientes { get; set; }


        public void ImprimirlistadoCliente()
        {
            Console.WriteLine("Lista de clientes");
            Console.WriteLine("Nombre\tApellido\tCedula\tEmail");
            foreach (var item in this.ListaClientes)
            {
               Console.WriteLine("{0}\t{1}\t\t{2}",
               item.Nombres,item.Apellido,item.NumeroCedula,item.Email);
            }
        }
    }
}

