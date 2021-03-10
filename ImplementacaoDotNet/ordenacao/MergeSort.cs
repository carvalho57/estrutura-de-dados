// C# program for Merge Sort
using System;
namespace ordenacao
{
    public partial class Sort
    {
        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }
        private static void MergeSort(int[] array, int left, int rigth)
        {
            if (left < rigth)
            {
                int middle = (left + rigth) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, rigth);
                Merge(array, left, middle, rigth);
            }
        }

        private static void Merge(int[] array, int left, int middle, int rigth)
        {
            var lowHalf = new int[(middle - left) + 1];
            var highHalf = new int[rigth - middle];

            Copy(array, lowHalf, left, middle);
            Copy(array, highHalf, middle + 1, rigth);

            int i = 0; //lowhalf - parte esquerda
            int j = 0; //highhalf - parte direita
            int k = left; //junção das duas partes

            while (i < lowHalf.Length && j < highHalf.Length)
            {
                if (lowHalf[i] < highHalf[j])
                {
                    array[k] = lowHalf[i];
                    i++;                    
                }
                else
                {
                    array[k] = highHalf[j];
                    j++;                    
                }
                k++;
            }
            while (i < lowHalf.Length)
            {
                array[k] = lowHalf[i];
                i++;
                k++;
            }

            while (j < highHalf.Length)
            {
                array[k] = highHalf[j];
                j++;
                k++;
            }

        }

        public static void Copy(int[] array, int[] copyTo, int startIndex, int lastIndex)
        {
            if (startIndex > lastIndex)
                throw new ArgumentOutOfRangeException("Indices conflitantes");

            for (int i = startIndex, j = 0; i <= lastIndex; i++, j++)
            {
                copyTo[j] = array[i];
            }
        }
    }

}