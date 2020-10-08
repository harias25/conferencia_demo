using conferencia_demo;
using System;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestSuma()
        {
            Operaciones operaciones = new Operaciones();
            Assert.Equal(4, operaciones.suma(2, 2));
        }

        [Fact]
        public void TestResta()
        {
            Operaciones operaciones = new Operaciones();
            Assert.Equal(0, operaciones.resta(2, 2));
        }

        [Fact]
        public void TestMultiplicacion()
        {
            Operaciones operaciones = new Operaciones();
            Assert.Equal(4, operaciones.multiplicacion(2, 2));
        }

        [Fact]
        public void TestDivision()
        {
            Operaciones operaciones = new Operaciones();
            Assert.Equal(1, operaciones.division(2, 2));
        }

    }
}
