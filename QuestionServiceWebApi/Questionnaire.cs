using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuestionServiceWebApi
{
    [DataContract]
    public class Questionnaire
    {
        [DataMember]
        public string QuestionnaireTitle { get; set; }
        [DataMember]
        public IList<string> QuestionsText { get; set; }
      
    }
}