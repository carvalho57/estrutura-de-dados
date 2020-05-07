import java.util.HashMap;
import java.util.LinkedHashSet;

public class MainApp {
    private static AlgoritmosOrdenacao algo;
    public static void main(String args[]) {
        int[] values = gerarValores(Integer.parseInt(args[0]));
        algo = new AlgoritmosOrdenacao();   

        System.out.println("Valores Gerados");     
        algo.mostrarVetor(values);
        
        System.out.println("\nBuble Sort");        
        algo.setVetor(values.clone());
        algo.bubleSort();
        algo.mostrarVetor();
        
    }

    private static int[] gerarValores(int value) {
        LinkedHashSet<Integer> list = new LinkedHashSet<Integer>();
        int number;
        do {
            number = (int)(Math.random() * 10000) % 10000;
            list.add(number);
        }while(list.size() <= value);
        return toInt(list);
    }
    public static int[] toInt(LinkedHashSet<Integer> linkhash) {
        int[] arr = new int[linkhash.size()];
        int i = 0;
        for (Integer val : linkhash) {
            arr[i++] = val;
        }
         
        return arr;
    }

}