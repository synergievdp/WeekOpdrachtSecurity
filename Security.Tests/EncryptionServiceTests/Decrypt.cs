using Security.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Security.Tests.EncryptionServiceTests
{
    public class Decrypt
    {
        private readonly EncryptionService encryptionService = new EncryptionService();

        [Fact]
        public void Should_Decrypt()
        {
            var password = "password";
            var expected = "Hello World";
            var enc = encryptionService.Encrypt(expected, password);

            var actual = encryptionService.Decrypt(enc, password);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Not_Decrypt()
        {
            var password = "password";
            var expected = "Hello World";
            var enc = encryptionService.Encrypt(expected, password);

            Action action = () => encryptionService.Decrypt(enc, "");

            Assert.Throws<CryptographicException>(action);
        }
    }
}
