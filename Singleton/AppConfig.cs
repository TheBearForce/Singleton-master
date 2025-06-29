using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class AppConfig
    {
        // Campo estático que contiene la única instancia de AppConfig.
        // Forma compatible con C# 8.0 y anteriores
        private static readonly Lazy<AppConfig> instance = new Lazy<AppConfig>(() => new AppConfig());

        // Propiedades de configuración
        public string ApiBaseUrl { get; private set; }
        public int Timeout { get; private set; }

        // Constructor privado para evitar la creación externa
        private AppConfig()
        {
            // Inicializa las configuraciones
            ApiBaseUrl = "https://dog-facts-api.com/api/v1/";
            Timeout = 30;  // Tiempo de espera en segundos
        }

        // Método público para acceder a la instancia única
        public static AppConfig Instance => instance.Value;

        // Método para actualizar configuraciones
        public void UpdateSettings(string apiUrl, int timeout)
        {
            ApiBaseUrl = apiUrl;
            Timeout = timeout;
        }

        // Método para mostrar las configuraciones actuales
        public void ShowSettings()
        {
            Console.WriteLine($"API Base URL: {ApiBaseUrl}");
            Console.WriteLine($"Timeout: {Timeout} seconds");
        }
    }
}

