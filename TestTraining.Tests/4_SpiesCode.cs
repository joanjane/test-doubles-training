namespace TestTraining.Tests.Spies
{
    public interface IEmailSender
    {
        void SendEmail(string address, string content);
    }

    public class EmailSenderSpy : IEmailSender
    {
        public int SentEmailCount { get; private set; }

        public void SendEmail(string address, string content)
        {
            SentEmailCount++;
        }
    }

    public class DoublesSpyExample
    {
        private readonly IEmailSender _emailSender;
        public DoublesSpyExample(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendWelcomeEmail(string address)
        {
            _emailSender.SendEmail(address, "Greetings");
        }
    }
}
