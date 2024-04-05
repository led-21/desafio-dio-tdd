using DesafioDioTDD;
using System.Diagnostics;
using Xunit.Abstractions;

namespace TesteDesafioDioTdd
{
    public class UnitTestCalculadora
    {

        private readonly ITestOutputHelper output;

        public UnitTestCalculadora(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 2, 6)]
        [InlineData (2, 4, 6)]
        public void TestCalculadorSomar(int x, int y, int resultadoEsperado)
        {
            Calculadora calculador = new();

            int resultado = calculador.Somar(x, y);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 2, 2)]
        [InlineData(2, 4, -2)]
        public void TestCalculadorSubtrair(int x, int y, int resultadoEsperado)
        {
            Calculadora calculador = new();

            int resultado = calculador.Subtrair(x, y);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 2, 8)]
        [InlineData(2, 4, 8)]
        public void TestCalculadorMultiplicar(int x, int y, int resultadoEsperado)
        {
            Calculadora calculador = new();

            int resultado = calculador.Multiplicar(x, y);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(2, 4, 0)]
        public void TestCalculadorDividir(int x, int y, int resultadoEsperado)
        {
            Calculadora calculador = new();

            int resultado = calculador.Dividir(x, y);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestCalculadorDividirPorZero() 
        {
            Calculadora calculadora = new();

            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(2, 0));
        }

        [Fact]
        public void TestCalculadorHistorico()
        {
            Calculadora calculadora = new();
            calculadora.Somar(2, 2);
            calculadora.Subtrair(2, 2);
            calculadora.Multiplicar(2, 2);
            calculadora.Dividir(2, 2);

            List<string> historico = calculadora.GetHistorico();

            foreach (string historicoItem in historico)
                output.WriteLine(historicoItem);

            Assert.NotEmpty(historico);
            Assert.Equal(4, historico.Count);
        }
    }
}