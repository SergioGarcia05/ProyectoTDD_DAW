using System;
using System.Collections.Generic;
using System.Text;

namespace MiProyecto.Tests
{
    public class PinTests
    {
        
            [Theory]
            [InlineData("1234")]
            [InlineData("123456")]
            [InlineData("9072")]
            [InlineData("908172")]
            public void EsPinValido_PinCorrecto_DevuelveTrue(string pin)
            {
                var matematicas = new MiProyecto.App.Matematicas();
                Assert.True(matematicas.EsPinValido(pin));
            }

            [Theory]
            [InlineData(null)]
            [InlineData("")]
            [InlineData("123")]
            [InlineData("12345")]
            [InlineData("1234567")]
            [InlineData("abcd")]
            [InlineData("12a4")]
            [InlineData("1111")]
            [InlineData("888888")]
            [InlineData("33333")]
            public void EsPinValido_PinIncorrecto_DevuelveFalse(string pin)
            {
                var matematicas = new MiProyecto.App.Matematicas();
                Assert.False(matematicas.EsPinValido(pin));
            }
        }
}
