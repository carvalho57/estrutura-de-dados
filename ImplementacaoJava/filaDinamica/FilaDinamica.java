public class FilaDinamica {
    private Node inicio;
    private Node fim;
    private int total;

    //[0] [1] [2] [3] [4] [5]
    public FilaDinamica() {
        inicio = null;
        fim = null;
        total = 0;
    }
    public void inserir(int elemento) {
        Node newNode = new Node(elemento);
        if(isEmpty()) {
            inicio = newNode;
            fim = newNode;
        } else {
            fim.setProximo(newNode);
            fim = newNode;
        }
        total++;
    }
    public int retirar() {
        int elemento = inicio.getElemento();
        inicio = inicio.getProximo();
        total--;
        return elemento;    
    }

    public boolean isEmpty() {
        return (total == 0);
    }
    public int tamanho() {
        return total;
    }
}