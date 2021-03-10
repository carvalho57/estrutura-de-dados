import java.util.HashMap;
import java.util.LinkedHashSet;

/*Como executar
    java MainApp quantidadeValores Algoritmo > saida.txt
    Algoritmo
    1 - Bubble Sort
    2 - Selection Sort
    3 -
    */
public class MainApp {
    private static AlgoritmosOrdenacao algo;
    public static void main(String args[]) {
        long[] values = gerarValores(Integer.parseInt(args[0]));
        algo = new AlgoritmosOrdenacao();   
        algo.setVetor(values);
        switch(Integer.parseInt(args[1])) {
            case 1:
                System.out.println("\nBubble Sort");        
                algo.bubleSort();
                algo.mostrarVetor();
                break;
            case 2:
                System.out.println("\nSelection Sort");                
                algo.selectionSort();
                algo.mostrarVetor();
                break;
            case 3:
                System.out.println("\nInsertion Sort");                
                algo.selectionSort();
                algo.mostrarVetor();
                break;
            case 4:
                System.out.println("\n Quick Sort");                
                algo.selectionSort();
                algo.mostrarVetor();
                break;
            default:
                System.out.println("\nInforme um valor válido");                
                break;
        }
    }

    private static long[] gerarValores(int value) {
        LinkedHashSet<Long> list = new LinkedHashSet<Long>();
        long number;
        do {
            number = (long)(Math.random() * (value * 100000)) % 100000;
            list.add(number);
        }while(list.size() <= value);
        return toInt(list);
    }
    
    public static long[] toInt(LinkedHashSet<Long> linkhash) {
        long[] arr = new long[linkhash.size()];
        int i = 0;
        for (Long val : linkhash) {
            arr[i++] = val;
        }
         
        return arr;
    }

}