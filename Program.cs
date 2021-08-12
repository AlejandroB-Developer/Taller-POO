using System;
using ModuloP;
using ModuloC;
using System.Collections.Generic;
using Taller_POO.Clientes;
using Taller_POO.Productos;



namespace taller_POO
{
    class Program
    {   
        public string nombreEmpresa;
         static void Main(string[] args)
        {
        principal();
        }

        public static void moduloConfiguracion(List<Empresa> nombreEmpresa)

        {
                var EmpresaServices = new  EmpresaServices();
                EmpresaServices.AgregarNombre(nombreEmpresa);
                
        }

        public static  void principal()
        { 
           
            int respuesta = 0;
            Boolean iniciar = true;
            
            var ListaCliente = new List<Clientes>();
            var ListaProducto = new List<Productos>();
            var nombreEmpresa = new List<Empresa>();

            while (iniciar)
            {
               switch (respuesta)
                {
                    case 1:
                    ModuloClientes.ModuloCliente(ListaCliente);
                     break;

                    case 2:
                    ModuloProductos.ModuloProducto(ListaProducto); 
                        break;
                    case 3:
                        
                        break;
                    case 4:
                       
                        break;
                     case 5:
                        moduloConfiguracion(nombreEmpresa);
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar este programa, adiós. :^)");
                        iniciar = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida. Ingrese las que se encuentran en el menú.");
                        break;
                }

                if (iniciar)
                {   
                    
                    Console.WriteLine("");
                    // Console.WriteLine("-------------------- Bienvenido al programa:"+nombreEmpresa+" -------------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Ingresar al módulo de clientes.");
                    Console.WriteLine("2: Ingresar al módulo de productos.");
                    Console.WriteLine("3: Ingresar al módulo de ventas.");
                    Console.WriteLine("4: Ingresar al módulo de reportes.");
                    Console.WriteLine("5: Configurar el sistema.");
                    Console.WriteLine("6: salir del programa. ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }

            
        }

        
}
}