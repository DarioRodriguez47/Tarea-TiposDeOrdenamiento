namespace Burbuja;
class Program
{
    static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        float[] A = { 50, 20, 40, 80, 30 };
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Comienza Burbuja: {0,15} {1,10}", "cambio", "pasada");
        Burbuja(A, 5);
        Console.WriteLine("Arreglo Ordenado: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(A[i] + " ");
        }
        watch.Stop();
        Console.WriteLine($"\nTiempo de ejecucion:{watch.ElapsedMilliseconds} milisegundos ");
    }

    static void Burbuja(float[] A, int n)
    {
        int i, j;
        float auxiliar;
        for (i = 0; i < n - 1; i++)
        {
            for (j = 0; j < n - 1 - i; j++)
            {
                if (A[j] > A[j + 1])
                {
                    auxiliar = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = auxiliar;
                }


                for (int k = 0; k < n; k++)
                {
                    Console.Write(A[k] + " ");
                }
                Console.Write("{0,15} {1} {2,10}", A[j], A[j + 1], i);
                Console.WriteLine();
            }
        }
    }
}
