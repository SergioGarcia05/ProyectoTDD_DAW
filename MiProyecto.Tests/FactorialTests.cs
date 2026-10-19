using MiProyecto.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiProyecto.Tests
{
    public class FactorialTests
    {
        private readonly Matematicas _matematicas = new Matematicas();

        [Fact]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            Assert.Equal(-1, _matematicas.CalcularFactorial(-5));
        }

        [Fact]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Assert.Equal(1, _matematicas.CalcularFactorial(0));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(7, 5040)]
        public void CalcularFactorial_NumeroPositivo_DevuelveFactorialCorrecto(int n, long esperado)
        {
            Assert.Equal(esperado, _matematicas.CalcularFactorial(n));
        }
    }
}
