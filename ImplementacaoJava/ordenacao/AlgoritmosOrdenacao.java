public class AlgoritmosOrdenacao {   
    private int[] vetor;

    public AlgoritmosOrdenacao() {
        
    }
    public void setVetor(int[] values) {
        this.vetor = values;
    }
    
    public void bubleSort() {
        int it;     // numero de iterações
        int pos;    // sempre uso a posicao atual
        int temp;

        for(it = 0; it < vetor.length - 1; it++) {
            for(pos = 0; pos < vetor.length - it - 1; pos++) {
                if(vetor[pos] > vetor[pos + 1]) {
                    temp = vetor[pos];
                    vetor[pos] = vetor[pos+1];
                    vetor[pos+1] = temp;
                }
            }
            //System.out.println("------> Final da iteração "+it);
            //mostrarVetor(vetor);
        }
        
    }

    public void mostrarVetor() {
        mostrarVetor(this.vetor);
    }

    public void mostrarVetor(int[] vetor) {
        
        for(int i = 0; i < vetor.length; i++) {
            System.out.print(vetor[i]+ ", ");
        }
        System.out.println("\nFIM");
        
    }
}