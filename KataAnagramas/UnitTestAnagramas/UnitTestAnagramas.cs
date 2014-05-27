using System;
using System.Collections.Generic;
using System.Linq;
using KataAnagramas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAnagramas
{
    [TestClass]
    public class UnitTestAnagramas
    {
        [TestMethod]
        public void TestMethodAnagramasRomaDevuelmeAmorOmarRamoOrmaMoraArmo()
        {
            List<String> resultadosEsperados = new List<String>();
            List<String> resultadosObtenidos = new List<String>();
            resultadosEsperados.Add("Amor");
            resultadosEsperados.Add("Omar");
            resultadosEsperados.Add("Ramo");
            resultadosEsperados.Add("Orma");
            resultadosEsperados.Add("Mora");
            resultadosEsperados.Add("Armo");
            resultadosObtenidos = Anagramas.obtenerAnagramas("Roma");
            resultadosEsperados.Sort();
            resultadosObtenidos.Sort();
            Assert.IsTrue((resultadosEsperados.SequenceEqual(resultadosObtenidos)),"");
        }
    }
}
