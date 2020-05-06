import javax.management.RuntimeErrorException;

public class ListaDuplaCircular {
    private Node inicio;
    private Node fim;
    public ListaDuplaCircular() {
        inicio = null;
        fim = null;
    }

    public boolean isEmpty() {
        return (inicio == null);
    }
    public void inserir(int elemento) {
        Node newNode = new Node(elemento);
        if(isEmpty()) {
            newNode.setProximo(newNode);
            newNode.setAnterior(newNode);
            inicio = newNode;
            fim = newNode;
        } else {            
            newNode.setProximo(inicio);
            newNode.setAnterior(fim);
            fim.setProximo(newNode);
            fim = newNode;
            inicio.setAnterior(fim);
        }
    }
    public boolean RemoverNoFinal() {
        if(isEmpty()) {return false;}
        if(RemoverSeInicioEFimSaoIguais()) {return true;}
        
        Node aux = fim.getAnterior();
        aux.setProximo(inicio);
        inicio.setAnterior(aux);
        fim = aux;
        return true;
    }

    public boolean RemoverNoInicio() {
        if(isEmpty()) {return false;}
        if(RemoverSeInicioEFimSaoIguais()) {return true;}

        Node aux = inicio.getProximo();
        aux.setAnterior(fim);
        fim.setProximo(aux);
        inicio = aux;
        return true;
    }

    public void exibirNaOrdem() {
        Node tmp;
        tmp = inicio;
        if(tmp == null) { throw new RuntimeException("A lista está vazia");}
        do {
            System.out.println("Elemento da lista: "+tmp.getElemento());
            tmp = tmp.getProximo(); 
        } while(tmp != inicio);
    }

    public void exibirNaOrdemInversa() {
        Node tmp;
        tmp = inicio;
        if(tmp == null) { throw new RuntimeException("A lista está vazia");}
        do {
            tmp = tmp.getAnterior();
            System.out.println("Elemento da lista: "+tmp.getElemento());            
        } while(tmp != inicio);
    }

    private boolean RemoverSeInicioEFimSaoIguais() {
        if(inicio == fim)  {
            inicio = null;
            fim = null;
            return true;
        }
        return false;
    }
} 