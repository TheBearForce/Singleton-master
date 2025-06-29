using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Acceder a la instancia única
            AppConfig config = AppConfig.Instance;
            config.ShowSettings();

            // Modificar configuraciones si es necesario
            config.UpdateSettings("https://new-dog-api.com/v2/", 60);

            // Verificar que los cambios se reflejan
            config.ShowSettings();
        }
    }
}
