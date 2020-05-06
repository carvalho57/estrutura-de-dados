public class Node {
    private int  elemento;
    private Node anterior;
    private Node proximo;

    public Node(int value) {
        setElemento(value);
    }

    public void setElemento(int elemento) {
        this.elemento =  elemento;
    }
    public void setAnterior(Node anterior) {
        this.anterior = anterior;
    }
    public void setProximo(Node proximo) {
        this.proximo = proximo;
    }
    public int getElemento() {
        return this.elemento;
    }
    public Node getAnterior() {
        return this.anterior;
    }
    public Node getProximo() {
        return this.proximo;
    }
}