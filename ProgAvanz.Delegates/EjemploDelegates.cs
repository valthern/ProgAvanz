using System.Runtime.InteropServices;

namespace ProgAvanz.Delegates
{
    public delegate void Imprimir<T>(T valor);

    public class EjemploDelegates
    {
        private void ImprimirPantalla(string v)
        {
            Console.WriteLine(v);
        }

        private void ImprimirPantalla(int v)
        {
            Console.WriteLine($"El valor es {v}");
        }

        public void EjemploDelegado()
        {
            Imprimir<string> imprimirDel = new Imprimir<string>(ImprimirPantalla);
            imprimirDel("Texto a imprimir");

            Imprimir<int> imprimirDelEntero = new Imprimir<int>(ImprimirPantalla);
            imprimirDelEntero(5);
        }

        public void EjemploAction()
        {
            Action<string> actionEjemplo = ImprimirPantalla;
            //actionEjemplo("Texto de \"string\" desde Action");
        }

        public void EjemploMetodoAnonimo()
        {
            Action<string> actionEjemploAnonimo = delegate (string valor) { Console.WriteLine(valor); };
            actionEjemploAnonimo("Valor a imprimir");

            Action<string> actionEjemploAnonimoLambda = valor => Console.WriteLine(valor);
            actionEjemploAnonimoLambda("Otro valor a imprimir");
        }

        public void EjemploFunc()
        {
            Func<int, string> delegadoFunc1 = v => $"El valor es {v}";
            Console.WriteLine(delegadoFunc1(23));
        }

        public void EjemploFunc2(
            )
        {
            Func<int, int, int> delegadoFunc2 = (v, x) => v * x;
            int resultado = delegadoFunc2(3, 4);

            Console.WriteLine($"El valor es {resultado}");
        }

        public void EjemploPredicate()
        {
            Predicate<int> mayorDeEdad = v => v >= 18;
            Console.WriteLine(mayorDeEdad(25) ? "Es mayor de edad" : "No es mayo de edad");
        }
    }
}
