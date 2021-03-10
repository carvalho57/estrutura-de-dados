public class test {
    public static void main(String args[]) {
        int[] values = new int[] {1,2,3,4,5,6,7,8,9,10};

        System.out.println("Busca binária");
        int value1 =buscaBinaria(values, 5);
        int value2 =buscaBinaria(values, 6);

        System.out.println("O valor 5 esta na posição: "+value1);
        System.out.println("O valor 6 esta na posição: "+value2);
    }
    
    private static int buscaBinaria(int[] values, int search){
        int inicio = 0;
        int meio;
        int fim = values.length - 1;

        while(inicio != fim) {
            meio = (inicio+ fim)/2;
            if(values[meio] == search)  {
                return meio;
            } else if(values[meio] > search) {
                fim = meio - 1;
            } else {
                inicio = meio + 1;
            }
        }

        return -1;
    }
}