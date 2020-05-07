public class MyApp {
    public static void main(String args[]) {
        Colecao cole = new Colecao();
        int number = Integer.parseInt(args[0]);
        System.out.println("Busca Sequencial");
        System.out.println("Posicao do elemento "+number+": "+cole.buscaSequencial(number));
        System.out.println("Busca Binária");
        System.out.println("Posicao do elemento "+number+": "+cole.buscaBinaria(number));
    }
}