using System;

namespace recursividade
{
    /*
    Para solucionar um problema, solucione um subproblema que seja uma
    instância menor do mesmo problema, e então use a solução dessa 
    instância menor para solucionar o problema original.

    Regras
    1 - Cada chamada recursiva deve ser em uma instância menor do mesmo problema, ou seja, um subproblema menor.
    2 - As chamadas recursivas precisam em algum ponto alcançar um caso base, que é resolvido sem outra recursão.
    */
    public class Recursion
    {
        public int FatorialIterativo(int n)
        {
            int result = 1;
            for (int i = result; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public int FatorialRecursivo(int n)
        {
            if (n == 0)
                return 1;

            return n * FatorialRecursivo(n - 1);
        }


        public bool Palindromo(string value)
        {
            if (value.Length == 0 || value.Length == 1) return true; //se chegar a um caracter todos os outros são iguais
            if (value[0] != value[value.Length - 1]) return false;// Verifica se o primeiro e o ultimo caracter são iguais
            return Palindromo(value.Substring(1, value.Length - 2)); //Chama palindromo passando uma string sem o primeiro
            // e o ultimo caracter
        }        // 2^3 = 2 * 2 * 2
        public double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            // recursive case: n is negative 
            if (n < 0)
            {
                return 1 / Power(x, -n);
            }
            // recursive case: n is odd
            if (IsOdd(n))
            {
                return x * Power(x, n - 1);
            }
            // recursive case: n is even

            var y = Power(x, n / 2);
            return y * y;
        }

        public bool IsOdd(double n) => n % 2 != 0;
    }
}