using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Biblioteca;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            #region PRUEBAS CLIENTE
            /*
            ENCliente cliente, cliente2, cliente3, cliente4;
            DateTime da = new DateTime(2013);
            List<ENCliente> lClientes;

            cliente = new ENCliente("1", 1, "Javi", "Roc", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "españa", "03340", "636273", da, "123");
            cliente2 = new ENCliente("1", 2, "Pepe", "Roc", 23, "asd@gmail.com", "casapepe"
             , "alicante", "albatera", "españa", "03340", "636273", da, "123");
            cliente3 = new ENCliente("3", 1, "Javi", "Roc", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "españa", "03340", "636273", da, "123");
            cliente4 = new ENCliente("4", 1, "ESEJUAN", "VIVAESPAÑA", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "españa", "03340", "636273", da, "123");
            cliente.InsertarCliente();
            cliente3.InsertarCliente();
            cliente2.ActualizarCliente();
            cliente3.EliminarCliente();
            cliente4.InsertarCliente();
            lClientes = cliente4.BuscarCliente();

            for (int i = 0; i < lClientes.Count; i++){
                Console.WriteLine(lClientes[i].Dni);
            }
            */
            #endregion

            #region PRUEBAS EMPLEADO

            ENEmpleado emp1, emp2, emp3, emp4;
            DateTime da = new DateTime(2013);
            List<ENEmpleado> lEmpleados;

            emp1 = new ENEmpleado("2", "javi", "roc", 23, "asd@gmail.com", "casapepe"
            , "alicante", "albatera", "03340", da, "nuevo", "636273", "123", "españa", "m");
            emp2 = new ENEmpleado("2", "pepino", "roc", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "03340", da, "nuevo", "636273", "123", "españa", "m");
            emp3 = new ENEmpleado("3", "JOSELE", "POKI", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "03340", da, "nuevo", "636273", "123", "españa", "m");
            emp4 = new ENEmpleado("4", "SOY EL ULTIMO", "VIVAESPAÑA", 23, "asd@gmail.com", "casapepe"
                , "alicante", "albatera", "03340", da, "nuevo", "636273", "123", "españa", "m");
            emp1.InsertarEmpleado();
            /*
            emp3.InsertarEmpleado();
            emp2.ActualizarEmpleado();
            emp3.EliminarEmpleado();
            emp4.InsertarEmpleado();
            lEmpleados = emp4.BuscarEmpleado();

            for (int i = 0; i < lEmpleados.Count; i++){
                Console.WriteLine(lEmpleados[i].Dni);
            }
            */
            #endregion

            #region PRUEBAS ADQUISICION
            /*
            ENAdquisicion eadq1, eadq2, eadq3, eadq4;
            List<ENAdquisicion> lAdquisiciones;

            eadq1 = new ENAdquisicion("1", 6.3f, "5", "4", "4");
            eadq2 = new ENAdquisicion("1", 7.5f, "8", "1", "2");
            eadq3 = new ENAdquisicion("2", 6.3f, "5", "1", "2");
            eadq4 = new ENAdquisicion("3", 6.3f, "5", "1", "2");
            eadq1.InsertarAdquisicion();
            eadq3.InsertarAdquisicion();
            eadq4.InsertarAdquisicion();
            eadq2.ActualizarAdquisicion();
            eadq3.EliminarAdquisicion();
            lAdquisiciones = eadq4.BuscarAdquisicion();

            for (int i = 0; i < lAdquisiciones.Count; i++){
                Console.WriteLine(lAdquisiciones[i].CodVenta);
            }
            */
            #endregion

            #region PRUEBAS PROVEEDOR
            //PRUEBAS PROVEEDOR
            /*
            ENProveedor proveedor1 = new ENProveedor("cif1", "disbesa", "disbesa@gmail.com", "calle la pepa, 8", "alicante", "Tibi", "03551", "9651475614");
            CADProveedor nuevoProv = new CADProveedor();
            //nuevoProv.InsertarProveedor(proveedor1);
            ENProveedor proveedor2 = new ENProveedor("111111", "codile", "codile@gmail.com", "calle la juana, 8", "alicante", "Castalla", "03552", "9677551412");
            CADProveedor nuevoProv2 = new CADProveedor();
            //nuevoProv2.InsertarProveedor(proveedor2);
            ENProveedor proveedor3 = new ENProveedor("22222", "hadaflix", "hada@gmail.com", "calle la luisa, 8", "africa", "albatera", "03352", "965465465412");
            ENProveedor proveedor4 = new ENProveedor("22222", "asdasdad", "hada@asdasdad.com", "calle la asdasdasd, 8", "afrasdasdica", "albatera", "03352", "965465465412");
            CADProveedor nuevoProv3 = new CADProveedor();
            //nuevoProv3.InsertarProveedor(proveedor3);
            CADProveedor viejoProv = new CADProveedor();
            //viejoProv.EliminarProveedor(proveedor1);
            nuevoProv.ActualizarProveedor(proveedor4);

            /*
            ENProveedor proveedor1 = new ENProveedor("cif1", "disbesa", "disbesa@gmail.com", "calle la pepa, 8", "alicante", "Tibi", "03551", "9651475614");
            CADProveedor nuevoProv = new CADProveedor();
            nuevoProv.InsertarProveedor(proveedor1);
            List<ENProveedor> listaProveedores;
            CADProveedor listaProv = new CADProveedor();
            listaProveedores = listaProv.BuscarProveedor();

            for (int i = 0; i < listaProveedores.Count; i++){
                Console.WriteLine(listaProveedores[i].Cif);
            }
            */
            #endregion

            #region PRUEBAS PRODUCTO
            /*
            //ENProducto prod1 = new ENProducto("1aaaa", "cif1", "la fuga", "castellutFilms", "108min", 'P', 10, "pelicula ciencia ficcion",18);
            //CADProducto nuevoProd = new CADProducto();
            //nuevoProd.InsertarProducto(prod1);
            ENProducto prod2 = new ENProducto("2bbbb", "cif1", "la huida", "tibiProductions", "120min", 'S', 10, "serie de terror", 21);
            prod2.InsertarProducto();
            //nuevoProd2.EliminarProducto(prod2);
            ENProducto prod3 = new ENProducto("3bbbb", "22222", "psicosis", "albateraStudios", "95min", 'P', 25, "thriller de tension", 13);
            prod3.InsertarProducto();
            //nuevoProd3.EliminarProducto(prod3);
            //viejoProd.EliminarProducto(prod1);
            
            
            ENProducto prod1 = new ENProducto("1aaaa", "cif1", "la fuga", "castellutFilms", "108min", 'P', 10, "pelicula ciencia ficcion", 18);
            ENProducto prod5 = new ENProducto("1aaaa", "cif1", "la fuga", "asdasdasdasdasdad", "108min", 'P', 10.3f, "pelicula ciencia ficcion", 18);
            prod1.InsertarProducto();
            prod5.ActualizarProducto();
            List<ENProducto> listaProductos;
            listaProductos = prod5.BuscarProducto();
            
            
            for (int i = 0; i < listaProductos.Count; i++)
            {
                Console.WriteLine(listaProductos[i].IdProducto);
            }
            */
            #endregion

            #region PRUEBAS PEDIDO
            /*
            ENPedido pedido1 = new ENPedido("1aaaa", "4", 4);
            CADPedido nuevoPedido = new CADPedido();
            //nuevoPedido.InsertarPedido(pedido1);
            //nuevoPedido.EliminarPedido(pedido1);
            */
            #endregion

            #region PRUEBAS ALQUILER
            /*
            DateTime da = new DateTime(2013);
            ENAlquiler lv1, lv2, lv3;
            List<ENAlquiler> lAlquileres;

            lv1 = new ENAlquiler("6", 6.3f, "5", "4", "4", da, da, 3.5f);
            lv2 = new ENAlquiler("6", 5.5f, "5", "4", "4", da, da, 5.7f);
            lv3 = new ENAlquiler("8", 5.5f, "5", "4", "4", da, da, 5.7f);
            lv1.InsertarAlquiler();
            lv3.InsertarAlquiler();
            lv2.ActualizarAlquiler();
            //lv1.EliminarAlquiler();
            //lv3.EliminarAlquiler();
            //lv2 = new ENLineaAdquisicion("3", "2bbbb", 10, 8.3f);


            //lv2.InsertarLineaAdquisicion();
            //lv1.EliminarLineaAdquisicion();
            //lv3.ActualizarLineaAdquisicion();
            lAlquileres = lv3.BuscarAlquileres();
            
            for (int i = 0; i < lAlquileres.Count; i++)
            {
                Console.WriteLine(lAlquileres[i].CodVenta);
            }
            */
            #endregion

            #region PRUEBAS VENTA
            /*
            DateTime da = new DateTime(2013);
            ENVenta lv1, lv2, lv3;
            List<ENVenta> lVentas;

            lv1 = new ENVenta("10", 6.3f, "5", "4", "4");
            lv2 = new ENVenta("10", 5.5f, "5", "4", "4");
            lv3 = new ENVenta("11", 5.5f, "5", "4", "4");
            //lv1.InsertarVenta();
            //lv3.InsertarVenta();
            //lv2.ActualizarVenta();
            lv1.EliminarVenta();
            lv3.EliminarVenta();
            //lv2 = new ENLineaAdquisicion("3", "2bbbb", 10, 8.3f);


            //lv2.InsertarLineaAdquisicion();
            //lv1.EliminarLineaAdquisicion();
            //lv3.ActualizarLineaAdquisicion();
            lVentas = lv3.BuscarAlquileres();
            
            for (int i = 0; i < lVentas.Count; i++)
            {
                Console.WriteLine(lVentas[i].CodVenta);
            }
            */
            #endregion
            Console.Read();
        }
    }
}
