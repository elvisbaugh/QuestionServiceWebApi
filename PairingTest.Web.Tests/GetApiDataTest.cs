using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PairingTest.Web.Interface;
using PairingTest.Web.Models;
using PairingTest.Web.Service;

namespace PairingTest.Web.Tests
{
   public class GetApiDataTest
    {
        [Test]
        public void GetDataFromApi()
        {
            //Arrange
            var getData = new GetDataFromApi();

            //Act
            var result =  getData.Request().Result;

            //Assert
            Assert.AreEqual(result.QuestionsText[0], "What is the capital of Cuba?");
            Assert.AreEqual(result.QuestionsText[1], "What is the capital of France?");
            Assert.AreEqual(result.QuestionsText[2], "What is the capital of Poland?");
            Assert.AreEqual(result.QuestionsText[3], "What is the capital of Germany?");


        }
    }
}
