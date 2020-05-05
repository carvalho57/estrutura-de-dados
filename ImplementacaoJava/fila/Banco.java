public class Banco {
    public static void main(String args[]) {
        Fila filaBanco = new Fila(10);
        int senha;
        filaBanco.inserir(1);
        filaBanco.inserir(2);
        filaBanco.inserir(3);
        filaBanco.inserir(4);
        filaBanco.inserir(5);
        filaBanco.inserir(6);
        filaBanco.inserir(7);
        filaBanco.inserir(8);
        filaBanco.inserir(9);
        filaBanco.inserir(10);
        
        
        System.out.println("Bem vindo a fila do banco");
        System.out.println("\tAtendimento");
        
        while(!filaBanco.isEmpty()) {
            senha = filaBanco.retirar();
            System.out.println("Senha "+senha);            
        }
    }
}