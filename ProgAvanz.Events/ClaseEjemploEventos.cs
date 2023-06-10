using System.Reflection.Metadata;

namespace ProgAvanz.Events
{
    public class EditorCalculadora
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public void Sumar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La suma es {a + b}");
            }
            else
                Console.WriteLine("No estás suscrito a los eventos.");
        }

        public void Restar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La resta es {a - b}");
            }
            else
                Console.WriteLine("No estás suscrito a los eventos.");
        }

        public void Multiplicar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La multiplicación es {a * b}");
            }
            else
                Console.WriteLine("No estás suscrito a los eventos.");
        }

        public void Dividir(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La división es {a / b}");
            }
            else
                Console.WriteLine("No estás suscrito a los eventos.");
        }
    }

    public class SuscriptorCalculadoraVirtual
    {
        private EditorCalculadora editor;
        private int a;
        private int b;

        public void EjemploEventHandler() => Console.WriteLine("La operación va a ser ejecutada.");

        public void EjemploEventHandler2() => Console.WriteLine("Este es nuestro segundo evento.");

        public SuscriptorCalculadoraVirtual(int a, int b)
        {
            editor = new EditorCalculadora();
            this.a = a;
            this.b = b;
            editor.ejemploEvento += EjemploEventHandler;
            editor.ejemploEvento += EjemploEventHandler2;
        }

        public void OperacionSuma() => editor.Sumar(a, b);

        public void OperacionResta() => editor.Restar(a, b);
    }
}
