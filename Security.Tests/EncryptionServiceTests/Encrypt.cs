using Security.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Security.Tests.EncryptionServiceTests
{
    public class Encrypt
    {
        private readonly EncryptionService encryptionService = new EncryptionService();

        [Fact]
        public void Should_Encrypt()
        {
            var actual = encryptionService.Encrypt("Hello World", "");

            Assert.NotEqual("Hello World", actual);
        }
    }
}
