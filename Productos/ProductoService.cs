using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Productos

{
    public class ProductoServices
    {
       // ---------------------------- AGREGAR ------------------------------
        public static void Agregar(List<Productos> ListaProductos)
        {   
            String codigo;
            String nombre;
            double precio;
            int cantidad;
            
            Console.WriteLine("");
            Console.WriteLine("------------ AGREGAR PRODUCTO ------------");
            Console.WriteLine("Por favor, ingrese los siguientes datos:");
            Console.WriteLine("Código del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Nombre del producto: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Precio del producto: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Cantidad del producto: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            var productos = new Productos(codigo, nombre, precio, cantidad);
            ListaProductos.Add(productos);
            Console.WriteLine("¡Producto agregado con éxito! :) ");

        }

        // ---------------------------- BUSCAR ------------------------------
        public static void Buscar(List<Productos> ListaProductos)
        {
             String codigo;

            Console.WriteLine("");
            Console.WriteLine("------------ AGREGAR PRODUCTO ------------");
            Console.WriteLine("Por favor, ingrese el código del producto para continuar: ");
            codigo = Console.ReadLine();

            var productos = ListaProductos.Where(p => p.codigo == codigo).FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("Consulta realizada. Estos son los datos que se encontraron: ");
            Console.WriteLine("Código: "+productos.codigo);
            Console.WriteLine("Nombre: "+productos.nombre);
            Console.WriteLine("Precio: "+productos.precio);
            Console.WriteLine("Cantidad: "+productos.cantidad);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Producto consultado con éxito :)");
            

        }

    // ----------------------------- EDITAR --------------------------------------

        public static void Editar(List<Productos> ListaProductos)
        {

            String codigo;
            String nombre;
            double precio;
            int cantidad;
            
            Console.WriteLine("");
            Console.WriteLine("---------------- EDITAR PRODUCTO --------------------");
            Console.WriteLine("Por favor, ingrese el código del producto para continuar");
            codigo = Console.ReadLine();

            var productos = ListaProductos.Where(p => p.codigo == codigo).FirstOrDefault();
            Console.WriteLine("");
            Console.WriteLine("Datos del producto que editará:");
            Console.WriteLine("Código: "+productos.codigo);
            Console.WriteLine("Nombre: "+productos.nombre);
            Console.WriteLine("Precio: "+productos.precio);
            Console.WriteLine("Cantidad: "+productos.cantidad);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Por favor, ingrese los siguientes datos para continuar: ");

            Console.WriteLine("Nuevo nombre del producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Nuevo precio del producto:");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Nueva cantidad del producto:");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            productos.nombre = nombre;
            productos.precio = precio;
            productos.cantidad = cantidad;

            Console.WriteLine("Edición realizada. Estos son los nuevos datos: ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Código: "+productos.codigo);
            Console.WriteLine("Nombre: "+productos.nombre);
            Console.WriteLine("Precio: "+productos.precio);
            Console.WriteLine("Cantidad: "+productos.cantidad);
            Console.WriteLine("Producto editado con éxito :)");
            Console.WriteLine("-------------------------------------------------------");
        }


     // ----------------------- ELIMINAR ------------------------------------------
        public static void Eliminar(List<Productos> ListaProductos)
        {   
             String codigo;

            Console.WriteLine("");
            Console.WriteLine("-------------------- ELIMINAR PRODUCTO ------------------");
            Console.WriteLine("Por favor, ingrese el código del producto para continuar.");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            var productos = ListaProductos.Where(p => p.codigo == codigo).FirstOrDefault();
            Console.WriteLine("Datos del producto que eliminará:");
            Console.WriteLine("Código: "+productos.codigo);
            Console.WriteLine("Nombre: "+productos.nombre);
            Console.WriteLine("Precio: "+productos.precio);
            Console.WriteLine("Cantidad: "+productos.cantidad);
            ListaProductos.Remove(productos);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("¡Producto eliminado con éxito! :) ");
        }
    }
}