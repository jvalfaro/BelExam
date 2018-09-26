using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen.BE;
using Examen.ServiceReference1;

namespace ExamTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Consulta()
        {
            ExamenServiceClient rpc = new ExamenServiceClient();
            string buscar = "pro";
            List<Examen.BE.Producto> listado = new List<Examen.BE.Producto>();
            listado = rpc.ListarProductos(buscar).ToList();
            Assert.IsTrue(true);
        }
    }
}
