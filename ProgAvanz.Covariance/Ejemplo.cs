using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanz.Covariance
{
    public class Ejemplo
    {
        public static void Imprimir(List<Persona> personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType()}");
            }
        }

        public static void Imprimir(IEnumerable<Persona> personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType()}");
            }
        }

        public static void RealizarAccionBecario(Action<Becario> accionBecario)
        {
            Becario b = new();
            accionBecario(b);
        }
    }
}
