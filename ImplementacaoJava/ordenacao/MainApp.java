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
        int[] values = gerarValores(Integer.parseInt(args[0]));
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
            default:
                System.out.println("\nInforme um valor válido");                
                break;
        }
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