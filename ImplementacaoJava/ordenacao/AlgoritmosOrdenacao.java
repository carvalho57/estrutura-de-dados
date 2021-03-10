public class AlgoritmosOrdenacao {   
    private long[] vetor;    
    public AlgoritmosOrdenacao() {
        
    }
    public void setVetor(long[] values) {
        this.vetor = values;
    }
    
    public void bubleSort() {
        int it;     // numero de iterações
        int pos;    // sempre uso a posicao atual
        long temp;

        for(it = 0; it < vetor.length - 1; it++) {
            for(pos = 0; pos < vetor.length - it - 1; pos++) {
                if(vetor[pos] > vetor[pos + 1]) {
                    temp = vetor[pos];
                    vetor[pos] = vetor[pos+1];
                    vetor[pos+1] = temp;
                }
            }           
            //System.out.println("Iteração "+it);
            //mostrarVetor();
        }        
    }
    public void selectionSort() {
        int it;
        int posMenorInicial;        
        int posMenor;
        int i;
        long aux;
        
        for(it = 0; it < vetor.length - 1; it++)  {
            posMenorInicial = it;
            posMenor = it + 1;
            for(i = posMenor; i < vetor.length; i++) {
                if(vetor[i] < vetor[posMenor]) {
                    posMenor = i;
                }
            }
            
            if(vetor[posMenor] < vetor[posMenorInicial]) {
                aux = vetor[posMenorInicial];
                vetor[posMenorInicial] = vetor[posMenor];
                vetor[posMenor] = aux;
            }
            //System.out.println("Iteração "+it);
            //mostrarVetor();
        } 
    }

    public void insertionSort() {
        long elementoIt;
        int it, pos;

        for(it = 1; it < vetor.length; it++) {
            elementoIt = vetor[it];
            for(pos = it - 1; (pos >= 0) && (vetor[pos] > elementoIt); pos--) {                
                vetor[pos+1] = vetor[pos];
            }
            vetor[pos+1] =  elementoIt;
            //System.out.println("Iteração "+it);
            //mostrarVetor();
        }
    }

    public void mostrarVetor() {
        mostrarVetor(this.vetor);
    }

    public void mostrarVetor(long[] vetor) {
        
        for(int i = 0; i < vetor.length; i++) {
            System.out.print(vetor[i]+ "  ");
        }
        System.out.println("\nFIM");
        
    }
}