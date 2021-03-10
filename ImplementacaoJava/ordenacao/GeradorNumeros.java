public class GeradorNumeros  {
    public static void main(String args[]) {
        int quantidade;
        boolean ordemCrescente;

        quantidade = Integer.parseInt(args[0]);
        ordemCrescente = Boolean.parseBoolean(args[1]);
        gerador(quantidade, ordemCrescente);
    }

    private static void gerador(int quantidade, boolean ordemCrescente) {
        System.out.println(ordemCrescente);
        if(ordemCrescente == true) {
            for(int i = 1; i <= quantidade; i++) {
                System.out.println(i+ " ");
            }
        } else {
            for(int i = quantidade; i >= 1; i--) {
                System.out.print(i+" " );  
            }
        }        
        
    }
}