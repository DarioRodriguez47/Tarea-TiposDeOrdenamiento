namespace Por_seleccion;
class Program
{
    static void Main(string[] args)
     {
         var watch = new System.Diagnostics.Stopwatch();
         watch.Start();

            float[] A = { 51, 21, 39, 80, 36 };

            Console.WriteLine("Arreglo desordenado: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Comienza ord. por selección: " + "cambio".PadRight(15) + "pasada".PadRight(10));
            Seleccion(A, 5);
            Console.WriteLine("Arreglo Ordenado por selección: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            watch.Stop();
             Console.WriteLine($"\nTiempo de ejecucion: {watch.ElapsedMilliseconds} milisegundos");
        }

        static void Seleccion(float[] A, int n)
        {
            int i, j, indiceMenor;
            float auxiliar;
            for (i = 0; i < n - 1; i++)
            {
                indiceMenor = i; // posición del menor
                for (j = i + 1; j < n; j++)
                {
                    if (A[j] < A[indiceMenor])
                    {
                        indiceMenor = j; // nueva posición del menor
                    }
                }
                auxiliar = A[indiceMenor]; // intercambia posiciones
                A[indiceMenor] = A[i];
                A[i] = auxiliar;
                for (int k = 0; k < n; k++)
                {
                    Console.Write(A[k] + " ");
                }
                Console.WriteLine(A[indiceMenor].ToString().PadRight(25) + A[i].ToString().PadRight(10) + i.ToString().PadRight(10));
            }
        }
    }
