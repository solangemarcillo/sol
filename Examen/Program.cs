using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesSinReistro clientesSinReistro = new ClientesSinReistro();
            clientesSinReistro.Nombres = "maikel";
            clientesSinReistro.Apellido = "zambran";
            clientesSinReistro.NumeroCedula = "222222";
            clientesSinReistro.Email = "a12.com";
            clientesSinReistro.Contrasenia = "1111";
            clientesSinReistro.CiudadDeFacturacion = "Manta";
            clientesSinReistro.FechaActual = "29/12/2019";

            Imprimir listadoClientes = new Imprimir();
            listadoClientes.ListaClientes.Add(clientesSinReistro);
            listadoClientes.ImprimirlistadoCliente();

            CrearStockProductos crearStockProductos = new CrearStockProductos();
            crearStockProductos.GeneraProductos();
            crearStockProductos.ImprimirListaProductos();

            Carrito carrito = new Carrito();
             
            string opcion;
            do
            {
                Console.WriteLine("inrese el codio de producto");
                int codio = int.Parse(Console.ReadLine());
                Detalledelcarrito detallecarrito = new Detalledelcarrito();
                detallecarrito.ProductoCarrito = crearStockProductos.StockProductos[codio - 1];
                Console.WriteLine("inrese la cantidad de productos eleidos");
                detallecarrito.Cantidad = Convert.ToInt32(Console.ReadLine());
                carrito.Detalle.Add(detallecarrito);
                Console.WriteLine("escriba A para seuir areando productos y S para salir");
                opcion = Console.ReadLine();
            } while (opcion != "S");

             
            listadoClientes.ImprimirlistadoCliente();
            Console.WriteLine("productos en el carrito de compras");
            Console.WriteLine("Descripcion\t\tCantidad\tPrecio");
           
            foreach (var item in carrito.Detalle)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}",
                    item.ProductoCarrito.Codigo, item.ProductoCarrito.Descripcion, item.Cantidad, item.ProductoCarrito.Precio);
            }
                carrito.CalcularSubtotal();
                carrito.CalcularDescuento();
                carrito.CalcularSubtotal2();
                carrito.CalcularIva();
                carrito.CalcularTotal();

                Console.WriteLine("SUBTOTAL");
                Console.WriteLine(carrito.SubTotal);

                Console.WriteLine("DESCUENTO");
                Console.WriteLine(carrito.Descuento);

                Console.WriteLine("SUBTOTAL-DESCUENTO");
                Console.WriteLine(carrito.SubTotal2);

                Console.WriteLine("IVA");
                Console.WriteLine(carrito.Iva);

                Console.WriteLine("TOTAL");
                Console.WriteLine(carrito.Total);
               
            }          
        }
    }

