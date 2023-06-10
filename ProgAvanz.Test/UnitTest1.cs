using ProgAvanz.Covariance;
using ProgAvanz.Delegates;
using ProgAvanz.Events;

namespace ProgAvanz.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Persona> personas = new()
            {
                new Becario(),
                new Jefe()
            };

            Ejemplo.Imprimir(personas);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Becario> becarios = new()
            {
                new Becario(),
                new Becario()
            };

            Ejemplo.Imprimir(becarios);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Jefe> jefes = new()
            {
                new Jefe(),
                new Jefe()
            };

            Ejemplo.Imprimir(jefes);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var accionBecario = new Action<Becario>(p => Console.WriteLine("Preparar el café."));
            if(accionBecario is not null) Ejemplo.RealizarAccionBecario(accionBecario);

            var accionJefe = new Action<Jefe>(p => Console.WriteLine("Preparar un meeting."));
            // Este NO funciona
            //if (accionJefe is not null) Ejemplo.RealizarAccionBecario(accionJefe);

            var accionEmpleado = new Action<Empleado>(p => Console.WriteLine("Trabaja."));
            if (accionEmpleado is not null) Ejemplo.RealizarAccionBecario(accionEmpleado);
        }
    }
}
