using System;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;

namespace PropiedadesBlazor.Servicios
{
    public class SubidaArchivos : ISubidaArchivos        
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly IConfiguration _configuration;

        public SubidaArchivos(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        bool ISubidaArchivos.BorrarArchivo(string nombreArchivo)
        {
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\ImagenesPropiedades\\{nombreArchivo}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<string> ISubidaArchivos.SubirArchivo(IBrowserFile archivo)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(archivo.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\ImagenesPropiedades";
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "ImagenesPropiedades", fileName);

                var memoryStream = new MemoryStream();
                await archivo.OpenReadStream().CopyToAsync(memoryStream);

                if(!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                await using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }

                var url = $"{_configuration.GetValue<string>("ServerUrl")}";
                var fullPath = $"{url}ImagenesPropiedades/{fileName}";
                return fullPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

