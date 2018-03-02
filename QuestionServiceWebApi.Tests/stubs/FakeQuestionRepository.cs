using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Tests.stubs
{

    public class FakeQuestionRepository : IQuestionRepository
    {
        public Questionnaire ExpectedQuestions { get; set; }
        public Questionnaire GetQuestionnaire()
        {
            return ExpectedQuestions;
        }
    }
}
