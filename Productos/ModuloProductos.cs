using System;
using System.Collections.Generic;
using Taller_POO.Productos;


namespace ModuloP

{

  public class ModuloProductos
  {
    public static void ModuloProducto (List <Productos> ListaProductos)
    {
        int respuesta = 0;

        var ProductoServices = new ProductoServices();
    
        Boolean iniciar = true;

            while (iniciar)
            {

               switch (respuesta)
                {
                    case 1:
                    ProductoServices.Agregar(ListaProductos);
                    break;

                    case 2:
                    ProductoServices.Buscar(ListaProductos); 
                    break;

                    case 3:
                    ProductoServices.Editar(ListaProductos);
                    break;

                    case 4:
                    ProductoServices.Eliminar(ListaProductos);
                    break;

                    case 5:
                        Console.WriteLine("Gracias por ingresar a este módulo, adiós. :^)");
                        iniciar = false;
                        break;
                        
                    default:
                        Console.WriteLine("La opción no es válida. Ingrese las que se encuentran en el menú.");
                        break;
                }

                if (iniciar)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-------------------- Bienvenido al módulo de productos. -----------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Agregar producto.");
                    Console.WriteLine("2: Buscar producto.");
                    Console.WriteLine("3: Editar producto.");
                    Console.WriteLine("4: Eliminar producto.");
                    Console.WriteLine("5: Salir de este módulo. ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
    }
  }
}