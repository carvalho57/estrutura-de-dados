import java.util.Scanner;

public class Conversor {
    public static void main(String args[])  {
        System.out.println("Conversor Decimal para Binário");
        System.out.print("Entre com um numero: ");
        Scanner entrada = new Scanner(System.in);

        int numero = entrada.nextInt();
        PilhaEstatica binarios = new PilhaEstatica(10);
        int resto;

        while(numero != 0)  {
            resto = numero % 2; // resto da divisão 0 ou 1
            numero = numero / 2;// gera o proximo numero
            binarios.push(resto); // armazena o resultado 0 ou 1
        }
        System.out.println("O Binario correspondente é: ");
        while(!binarios.isEmpty()) {
            resto = binarios.pop();
            System.out.print(resto);
        }
        System.out.println("\n Fim do programa");
    }
}

/*
172 / 2
   0 86 /2
        0 43 / 2
            1 21 / 2
                1 10
                    0 5 / 2 
                        1 2 / 2
                            0 / 2
                                1  0 */
