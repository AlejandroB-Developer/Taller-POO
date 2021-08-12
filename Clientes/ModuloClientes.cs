using System;
using System.Collections.Generic;
using Taller_POO.Clientes;
using taller_POO;

namespace ModuloC

{

  public class ModuloClientes
  {
    public static void ModuloCliente (List <Clientes> ListaClientes)
    {
        int respuesta = 0;
        Boolean iniciar = true;

            while (iniciar)
            {

               switch (respuesta)
                {
                    case 1:
                    
                       ClienteService.Agregar(ListaClientes);
                    break;

                    case 2:
                       ClienteService.Buscar(ListaClientes); 
                    break;

                    case 3:
                        ClienteService.Editar(ListaClientes);
                    break;

                    case 4:
                        ClienteService.Eliminar(ListaClientes);
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
                    Console.WriteLine("-------------------- Bienvenido al módulo de clientes. -----------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Agregar Cliente.");
                    Console.WriteLine("2: Buscar Cliente.");
                    Console.WriteLine("3: Editar cliente.");
                    Console.WriteLine("4: Eliminar cliente.");
                    Console.WriteLine("5: Salir de este módulo. ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
    }
  }
}