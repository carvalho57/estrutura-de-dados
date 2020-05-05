public class PilhaEstatica {
    private int valores[];
    private int topo;

    public PilhaEstatica(int tamanho) {
        if(tamanho <= 0) {
            tamanho = 10;
        }
        valores = new int[tamanho];
        topo = -1;
    }

    public boolean push(int elemento) {        
        if(!isFull()) {
            topo++;
            valores[topo] = elemento;                             
            return true;
        }        
        return false;
    }

    public boolean isEmpty() {
        return (topo == -1);
    }

    public boolean isFull() {
        return (topo == 9);
    }
    public int pop() {
        if(!isEmpty()) {
            int elem = valores[topo];
            topo--;
            return elem;     
        }   
        return topo;
    }
}