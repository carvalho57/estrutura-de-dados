public class ListaEspera {
    public static void main(String args[]) {
        ListaEncadeada lista = new ListaEncadeada();
        lista.inserir(2); 
        lista.inserir(3); 
        lista.inserir(4); 
        lista.inserir(8); 
        lista.inserir(10); 
        int e;
        StringBuilder builder = new StringBuilder();
        //lista.listar();
        while(!lista.isEmpty()) {
            e = lista.retirar();
            builder.append(e);
        }
        System.out.println(builder.toString());
    }
}