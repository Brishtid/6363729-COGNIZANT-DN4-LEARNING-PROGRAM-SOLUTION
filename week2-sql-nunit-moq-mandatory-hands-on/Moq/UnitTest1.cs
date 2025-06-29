using CustomerCommLib;
using Moq;
using NUnit.Framework;
using System.ComponentModel;

namespace CustomerCommLib.Tests
{
    public class Tests
    {
        [Test]
        public void SendMailToCustomer_WhenCalled_ReturnsTrue()
        {
            
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            var customerComm = new CustomerComm(mockMailSender.Object);

            
            var result = customerComm.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.True);
            mockMailSender.Verify(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
