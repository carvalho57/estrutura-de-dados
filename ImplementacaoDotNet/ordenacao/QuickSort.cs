namespace ordenacao
{
    public partial class Sort
    {
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        public static void QuickSort(int[] array, int p, int r)
        {
            if (p < (r + 1))
            {
                var pivo = Partition(array, p, r);
                QuickSort(array, p, pivo - 1);
                QuickSort(array, pivo + 1, r);
            }
        }
        private static int Partition(int[] arr, int p, int r)
        {
            /*Divide o array em setores menor(L), maior(G) e desconhecido(U)            
            q representa o limite o setor dos menores - (também é o elemento)
            j representa os elementos desconhecido       
            o pivo que é Array[r] (O elemento mais a direita)
            p   L    q     G     j      r
            [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]
            
            se o elemento for maior só incrementa j - Assim aumentando o setor G
            se o elemento for menor, troca o elemento com q - Assim aumentando o
            setor de L
            */
            int q = p;

            for (int j = p; j < r; j++)
            {
                if (arr[j] <= arr[r])
                {
                    Swap(j, q, arr);
                    q++;
                }
            }
            Swap(q, r, arr);
            return q; 
        }
    }

}
