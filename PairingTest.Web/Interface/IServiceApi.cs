using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PairingTest.Web.Models;

namespace PairingTest.Web.Interface
{
    public interface IServiceApi
    {
       Task<QuestionnaireViewModel> Request();
    }
}
