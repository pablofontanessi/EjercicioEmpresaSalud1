using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

using System.Net;
namespace TestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
      

        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            // var responseMessage = new HttpResponseMessage<List<string>>(errors, HttpStatusCode.BadRequest);
            var response = new System.Web.Http.;

            var numero = 1;
            //var Error = new HttpError();
            //Error.Message = "no";
           // var ErrorEspera = new HttpResponseException(responseMessage);

            //act
            var prueba = new WEBAPIEmpresaSalud.Controllers.ContratacionController();
            var prueba1 = prueba.Post(numero);
            // ErrorEsperado.Add(prueba1);

            //asset
            Assert.AreEqual(response, prueba1);



        }
    }
}
