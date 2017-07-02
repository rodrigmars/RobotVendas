using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace RobotVendas.Tests
{
    public class Class1
    {
        public Class1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        [Theory]
        [InlineData(DayOfWeek.Saturday)]
        public void ValidaSeDiaÉSábado(DayOfWeek dia)
        {
            Assert.True(dia == IdentificaDia(DayOfWeek.Saturday));
        }

        [Theory]
        [InlineData(DayOfWeek.Sunday)]
        public void ValidaSeDiaÉDomingo(DayOfWeek dia)
        {
            Assert.True(dia == IdentificaDia(DayOfWeek.Sunday));
        }

        [Theory]
        [InlineData(150.0, DayOfWeek.Saturday)]
        public void DefineValorProdutoSeDiaForSábado(decimal valorProduto, DayOfWeek dia)
        {
            DefineValorProdutoDiaNaoUtil(ref valorProduto, dia);
            Console.WriteLine($"valorProduto: {valorProduto}");
            Assert.True(valorProduto == 165m);
        }

        [Theory]
        [InlineData(150.0, DayOfWeek.Sunday)]
        public void DefineValorProdutoSeDiaForDomingo(decimal valorProduto, DayOfWeek dia)
        {
            DefineValorProdutoDiaNaoUtil(ref valorProduto, dia);
            Console.WriteLine($"valorProduto: {valorProduto}");
            Assert.True(valorProduto == 172.5m);
        }

        public void DefineValorProdutoDiaNaoUtil(ref decimal valor, DayOfWeek dia)
        {
            if (dia == IdentificaDia(DayOfWeek.Saturday))
            {
                valor = valor + (valor * 0.1m);
            }
            else if ((dia == IdentificaDia(DayOfWeek.Sunday)))
            {
                valor = valor + (valor * 0.15m);
            }
        }

        public void DefineValorProdutoDiaNaoUtil(ref decimal valor)
        {
            var dia = DateTime.Now.DayOfWeek;

            if (dia == IdentificaDia(DayOfWeek.Saturday))
            {
                valor = valor + (valor * 0.1m);
            }
            else if ((dia == IdentificaDia(DayOfWeek.Sunday)))
            {
                valor = valor + (valor * 0.15m);
            }
        }

        public DayOfWeek IdentificaDia(DayOfWeek day)
        {
            return (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Enum.GetName(typeof(DayOfWeek), day));
        }
    }
}
