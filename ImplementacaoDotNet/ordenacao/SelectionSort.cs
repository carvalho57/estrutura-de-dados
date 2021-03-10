namespace ordenacao
{
    public partial class Sort
    {
        // Encontre os menores elementos e coloque eles nas primeiras posições  
        public static void SelectionSort(int[] arr)
        {
            /*
                1 - Fixar as posições
                2 - Encontrar o menor valor na iteração
                3 - Trocar a posição fixica com o menor valor
            */
            int minPosition = -1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minPosition = indexOfMinimum(arr, i);
                Swap(minPosition, i, arr);
            }
        }

        private static int indexOfMinimum(int[] array, int startIndex = 0)
        {
            int minIndex = startIndex;
            for (int i = minIndex + 1; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                    minIndex = i;
            }
            return minIndex;
        }

        private static void Swap(int first, int second, int[] arr)
        {
            if (first != second)
            {
                int aux = arr[first];
                arr[first] = arr[second];
                arr[second] = aux;
            }
        }
    }
}