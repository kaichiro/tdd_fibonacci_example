using System;

namespace MyFibonacci
{
    public class Fibonacci
    {
        public int calcularTermo(int entrada_01, int entrada_02)
        {
            return entrada_01 + entrada_02;
        }

        public int calcularTermoNaPosicao(int posicao)
        {
            int fibonacciTherm = 0;
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 1; i < posicao; i++)
            {
                firstNumber = secondNumber;
                secondNumber = fibonacciTherm;
                fibonacciTherm = calcularTermo(firstNumber, secondNumber);
            }

            return fibonacciTherm;
        }

        public int[] gerarSequencia(int v)
        {
            int[] serie = new int[20];

            for (int i = 1; i <= v; i++)
            {
                serie[i - 1] = calcularTermoNaPosicao(i);
            }

            return serie;
        }
    }
}
