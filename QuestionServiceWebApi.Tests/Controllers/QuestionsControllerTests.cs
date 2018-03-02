
using QuestionServiceWebApi.Controllers;
using NUnit.Framework;
using QuestionServiceWebApi.Tests.stubs;

namespace QuestionServiceWebApi.Tests.Controllers
{
    [TestFixture]
    public class QuestionsControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var expectedQuestions = new Questionnaire() { QuestionnaireTitle = expectedTitle };
            var fakeQuestionRepository = new FakeQuestionRepository() { ExpectedQuestions = expectedQuestions };
            var questionsController = new QuestionsController(fakeQuestionRepository);

            //Act
            var questions = questionsController.Get();

            //Assert
            Assert.That(questions.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}
