using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {
        private CalculadoraImp _calc;

        public CalculadoraTestes()
        {
            _calc = new CalculadoraImp();
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(1, 4)]
        public void DeveSomarCorretamenteERetornar5(int num1, int num2)
        {
            // Arrange
            // int num1 = 5;
            // int num2 = 10;

            // Act
            int resultado = _calc.Somar(num1, num2);
            
            // Assert
            Assert.Equal(5, resultado);

        }
    }
}