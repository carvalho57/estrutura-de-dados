namespace ordenacao
{
    public partial class Sort
    {
        public static void InsertionSort(int[] array)
        {
            /*
               Seleciona uma chave
               Verifica se os elementos a esquerda são maiores
               Se forem mova para a direita
               Quando o elemento for menor coloque a chave
               ao lado desse elemento;
            */
            int key;
            for (int i = 1; i < array.Length; i++)
            {
                int k;
                key = array[i];
                for (k = i - 1; k >= 0 && array[k] > key; k--)
                    array[k + 1] = array[k];
                array[k + 1] = key;
            }

        }
    }
}