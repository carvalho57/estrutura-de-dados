public class ListaEncadeada {
    private Node inicio;

    public ListaEncadeada() {
        this.inicio = null;
    }
    public void inserir(int elemento) {
        Node nova = new Node(elemento);
        nova.setProximo(null);
        if(isEmpty()) {
            inicio = nova;        
        } else {
            Node aux = inicio;
            while(aux.getProximo() != null) {
                aux = aux.getProximo();
            }            
            aux.setProximo(nova);
        }

    }
    public int retirar() {        
        int elemento = inicio.getElemento();
        inicio = inicio.getProximo();
        return elemento;
    }
    public void listar() {
        if(!isEmpty()) {
            Node aux = inicio;
            while(aux != null) {
                System.out.println("Elemento: "+aux.getElemento());
                aux = aux.getProximo();
            }
        }
    }

    public boolean isEmpty() {
        return (this.inicio == null);
    }
}