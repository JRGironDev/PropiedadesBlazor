using System;
using Microsoft.AspNetCore.Components.Forms;

namespace PropiedadesBlazor.Servicios
{
	public interface ISubidaArchivos
	{
		Task<string> SubirArchivo(IBrowserFile archivo);

		bool BorrarArchivo(string nombreArchivo);
	}
}

