using Microsoft.Extensions.Configuration;
using System;

namespace BaseDatos
{
    public class Conexion
    {
        public string ConexionBd()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            string rutaConexion = configuration.GetConnectionString("Conexion");

            return rutaConexion;
        }
    }
}