using System;

namespace ordenacao 
{
    public partial class Sort
    {
        /* 
            4 3 2 1 - 3 4 2 1 - 2 4 3 1 - 1 4 3 2
            1 4 3 2 - 1 3 4 2 - 1 3 4 2 - 1 2 4 3
            1 2 4 3 - 1 2 3 4         
        */
       public static void BubleSort(int[] arr)
       {
           for(int i = 0; i < arr.Length; i++)
           {
               for(int j = i + 1; j < arr.Length; j++)
                if(arr[i] > arr[j])
                        Swap(i,j,arr);     
                              
           }
            
       }
    }
}