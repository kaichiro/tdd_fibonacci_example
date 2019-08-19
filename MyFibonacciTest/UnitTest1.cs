using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFibonacci;

namespace MyFibonacciTest
{
    [TestClass]
    public class UnitTest1
    {
        #region Teste de retorno simples
        [TestMethod]
        public void Test_Para_00_e_01_deve_retornar_1()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 0;
            int entrada_02 = 1;
            int esperado = 1;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_01_e_01_deve_retornar_2()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 1;
            int entrada_02 = 1;
            int esperado = 2;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_01_e_02_deve_retornar_3()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 1;
            int entrada_02 = 2;
            int esperado = 3;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_02_e_03_deve_retornar_5()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 2;
            int entrada_02 = 3;
            int esperado = 5;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_03_e_05_deve_retornar_8()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 3;
            int entrada_02 = 5;
            int esperado = 8;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_05_e_08_deve_retornar_13()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 5;
            int entrada_02 = 8;
            int esperado = 13;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_Para_08_e_13_deve_retornar_21()
        {
            Fibonacci objeto = new Fibonacci();
            int entrada_01 = 8;
            int entrada_02 = 13;
            int esperado = 21;
            int atual = objeto.calcularTermo(entrada_01, entrada_02);
            Assert.AreEqual(esperado, atual);
        }
        #endregion

        #region Teste de teste de retorno simples
        [TestMethod]
        public void Test_posicao_1_retornar_termo_0()
        {
            Fibonacci objeto = new Fibonacci();
            int posicao = 1;
            int esperado = 0;
            int atual = objeto.calcularTermoNaPosicao(posicao);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_posicao_2_retornar_termo_1()
        {
            Fibonacci objeto = new Fibonacci();
            int posicao = 2;
            int esperado = 1;
            int atual = objeto.calcularTermoNaPosicao(posicao);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_posicao_3_retornar_termo_1()
        {
            Fibonacci objeto = new Fibonacci();
            int posicao = 3;
            int esperado = 1;
            int atual = objeto.calcularTermoNaPosicao(posicao);
            Assert.AreEqual(esperado, atual);
        }

        [TestMethod]
        public void Test_posicao_4_retornar_termo_2()
        {
            Fibonacci objeto = new Fibonacci();
            int posicao = 4;
            int esperado = 2;
            int atual = objeto.calcularTermoNaPosicao(posicao);
            Assert.AreEqual(esperado, atual);
        }
        #endregion

        [TestMethod]
        public void Test_gerar_20_termos()
        {
            Fibonacci objeto = new Fibonacci();
            int[] arrayEsperado = new int[20]
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21,
                34, 55, 89, 144, 233, 377,
                610, 987, 1597, 2584, 4181
            };
            int[] arrayAtual = objeto.gerarSequencia(20);
            CollectionAssert.AreEqual(arrayEsperado, arrayAtual);
        }
    }
}
