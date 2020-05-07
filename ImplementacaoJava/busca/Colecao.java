public class Colecao {    
    private int valores[] = {7,12,13,14,15,23,27,33,56,61,64,87,89};
    public int buscaSequencial(int valor) {
        int iteracoes = 0;
        for(int posicao = 0; posicao < valores.length; posicao++) {
            iteracoes++;            
            if(valor == valores[posicao])  {
                System.out.println("O número de iterações foi :"+iteracoes);
                return posicao;
            }
        }
        System.out.println("O número de iterações foi :"+iteracoes);
        return -1; 
    }    
    public int buscaBinaria(int valor)    {
        int iteracoes = 0;
        int meio, inicio, fim;
        inicio = 0;
        fim = valores.length -1 ;

        while(inicio <= fim) {
            iteracoes++;
            meio = (inicio + fim) / 2;
            if(valor == valores[meio])  {
                System.out.println("O número de iterações foi :"+iteracoes);
                return meio;
            }
            else if(valor > valores[meio]) {
                inicio = meio + 1;
            } else {
                fim = meio -1;
            }
        }
        System.out.println("O número de iterações foi :"+iteracoes);
        return -1;
    }
}