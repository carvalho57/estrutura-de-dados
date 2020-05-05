

public class Fila {
    private int[] valores;
    private int inicio;
    private int fim;
    private int total;       

    public Fila(int tamanho) {
        valores = new int[tamanho];
        inicio = 0;
        fim = 0;
        total = 0;                        
    }

    public boolean inserir(int elemento) {        
        if(total == length()) {
            valores[fim] = elemento;
            fim = (fim + 1)% length();
            total++;
            return true;
        }
        return false;
    }
    public int retirar() {    
        int elem = valores[inicio];
        inicio = (inicio + 1)% length();
        total--;
        return elem;
        
    }
    public boolean isEmpty() {
        return (total == 0);
    }
    public boolean isFull() {
        return total == length();
    }

    private int length() {
        return valores.length;
    }
}