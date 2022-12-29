namespace Quickshort;

class Program
{
    static void Main(string[] args)
  {
        float[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24 };
        int n = A.Length;
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        //Console.WriteLine("Comienza ord. por insercion: ");
        QuickSort(A, 0, n - 1);
        Console.WriteLine("Arreglo Ordenado por inserción lineal: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
    }

    public static void QuickSort(float[] a, int primero, int ultimo)
    {
        int i, j, central;
        float pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                float tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */
    }
}