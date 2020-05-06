public class Program {
    public static void main(String args[]) {
        ListaDuplaCircular lista = new ListaDuplaCircular();
        lista.inserir(10);
        lista.inserir(20);
        lista.inserir(30);
        lista.inserir(40);

        System.out.println("Exibir na ordem");
        lista.exibirNaOrdem();
        System.out.println("Exibir na ordem inversa");
        lista.exibirNaOrdemInversa();
        System.out.println("Removendo último elemento");
        lista.RemoverNoFinal();
        lista.exibirNaOrdem();
        System.out.println("Removendo primeiro elemento");
        lista.RemoverNoInicio();
        lista.exibirNaOrdem();
        System.out.println("Removendo os elementos restantes");
        while(!lista.isEmpty()) {            
            lista.RemoverNoFinal();
        }
        try {
            lista.exibirNaOrdem();
        }catch(Exception e) {
            System.out.println(e);
        }
    }
}