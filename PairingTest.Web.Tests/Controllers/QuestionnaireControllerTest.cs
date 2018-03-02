using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using PairingTest.Web;
using PairingTest.Web.Controllers;
using PairingTest.Web.Interface;
using PairingTest.Web.Models;


namespace PairingTest.Web.Tests.Controllers
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "Geography Questions";
            var questionnaireController = new QuestionnaireController();

            //Act
            var result = questionnaireController.Index().Result;
            var title = (QuestionnaireViewModel) result.ViewData.Model;
           
            //Assert
            Assert.That(title.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void GetQuestionnairQuestions()
        {
            //Arrange
            var questionnaireController = new QuestionnaireController();

            //Act
            var result = questionnaireController.Index().Result;
            var questionnaire = (QuestionnaireViewModel) result.ViewData.Model;

            //Assert
            Assert.That(questionnaire.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.QuestionsText[2], Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionnaire.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));
        }

    }
}
