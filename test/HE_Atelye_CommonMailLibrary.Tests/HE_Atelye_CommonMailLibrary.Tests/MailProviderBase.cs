using CommonMailLibrary.Interfaces;
using FakeItEasy;
using Xunit;
using Should;

namespace HE_Atelye_CommonMailLibrary.Tests
{
    public class MailProviderBaseTest
    {
        private readonly MailRequest mailRequest;

        public MailProviderBaseTest()
        {
            mailRequest = FakeItConfiguration.CreateMailRequest();
            var mailProviderBase = new Fake<CommonMailLibrary.Interfaces.MailProviderBase>();
        }

        [Fact]
        [InlineData()]
        public virtual void MailProviderBase_SendEmail_Test(int mailRequestCount)
        {

            
        }

    }
}
