using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonMailLibrary.Interfaces;

namespace HE_Atelye_CommonMailLibrary.Tests
{
    public static class FakeItConfiguration
    {
        public static MailRequest CreateMailRequest()
        {
            return FakeItEasy.A.Fake<MailRequest>(options => options.ConfigureFake(request =>
           {
               request.Subject = string.Empty;
               request.Body = string.Empty;
               request.From = string.Empty;

           }));
        }
    }
}
