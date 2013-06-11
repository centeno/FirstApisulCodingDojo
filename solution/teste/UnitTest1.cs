using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoCinema.src;

namespace DojoCinema
{
    [TestClass]
    public class TesteIngressoCinema
    {
        [TestMethod]
        public void testeValorSegunda()
        {
            decimal valorCrianca = Ingresso.CalcularPreco(TipoPessoa.CRIANCA, DayOfWeek.Monday);
            Assert.AreEqual(4.95M, valorCrianca);

            decimal valorEstudante = Ingresso.CalcularPreco(TipoPessoa.ESTUDANTE, DayOfWeek.Monday);
            Assert.AreEqual(7.20M, valorEstudante);

            decimal valorIdoso = Ingresso.CalcularPreco(TipoPessoa.IDOSO, DayOfWeek.Monday);
            Assert.AreEqual(5.40M, valorIdoso);
        }

        [TestMethod]
        public void testeValorTercaEstudante()
        {
            Estudante e = new Estudante();
            IngressoTerca i = new IngressoTerca(e);
            Assert.AreEqual(7.60M, i.valor());
        }

        [TestMethod]
        public void testeValorTercaCrianca()
        {
            Crianca c = new Crianca();
            IngressoTerca i = new IngressoTerca(c);
            Assert.AreEqual(4.675M, i.valor());
        }
    
    }
}
