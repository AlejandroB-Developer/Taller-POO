using System;
using System.Collections.Generic;
using System.Linq;
public class EmpresaServices
{
	public static void AgregarNombre(List<Empresa> nombreEmpresa)
	{
        Console.WriteLine("Digite el nombre de la empresa: ");
		string configuracionNombre = Console.ReadLine();
		var nombre = new Empresa(configuracionNombre);
		nombreEmpresa.Add(nombre);
	}
}