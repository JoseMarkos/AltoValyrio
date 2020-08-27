using Alto_Valyrio.src.Inventory.Auth.Application;
using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAltoValyrio.src.Inventory.Auth.Infrastructure
{
    public class AuthRespositoryTest
    {
        [Fact]
        public void InvalidUsername()
        {
            var username = new AuthUsername("Jose");
            AuthPassword password = new AuthPassword("123");
            var auth = new AuthUser(username, password);
            Assert.Throws<InvalidAuthUsernameExeption>(
                () =>
                {
                    var repository = new SQLServerRepository();
                    var authenticator = new UserAuthenticator(repository);
                    authenticator.Authenticate(username, password);
                }
                );
        }

        [Fact]
        public void InvalidCredentials()
        {
            var username = new AuthUsername("Marcos");
            AuthPassword password = new AuthPassword("123");
            var auth = new AuthUser(username, password);
            Assert.Throws<InvalidAuthCredentialsException>(
                () =>
                {
                    var repository = new SQLServerRepository();
                    var authenticator = new UserAuthenticator(repository);
                    authenticator.Authenticate(username, password);
                }
                );
        }

        [Fact]
        public void registrationPass()
        {
            var username = new AuthUsername("Marcos");
            AuthPassword password = new AuthPassword("hola");
            var repository = new SQLServerRepository();
            var authenticator = new UserAuthenticator(repository);
            authenticator.Authenticate(username, password);

            Assert.True(true);
        }
    }
}
