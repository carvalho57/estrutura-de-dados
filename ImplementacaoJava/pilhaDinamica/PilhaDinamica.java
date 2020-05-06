public class PilhaDinamica implements IPilha {
    private Node topo;

    public PilhaDinamica() {
        topo = null;
    }

    public void push(int elemento) {
        Node newTopo = new Node(elemento);
        newTopo.setProximo(topo);
        topo = newTopo;        
    }

    public int pop() {
        int elemento = topo.getElemento();
        topo = topo.getProximo();
        return elemento;
    }


    public boolean isEmpty() {
        return (topo == null);
    }
}