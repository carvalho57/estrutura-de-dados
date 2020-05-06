public class Node {
    private int elemento;
    private Node proximo;
    public Node() {}
    public Node(int elemento) {
        setElemento(elemento);
    }
    public void setElemento(int elemento) {
        this.elemento = elemento;
    }
    
    public int getElemento() {
        return this.elemento;
    }

    public void setProximo(Node proximo) {
        this.proximo = proximo;
    }

    public Node getProximo() {
        return this.proximo;
    }
}