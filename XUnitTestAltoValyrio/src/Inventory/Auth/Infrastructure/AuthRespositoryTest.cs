using Alto_Valyrio.src.Inventory.Auth.Applications;
using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using Xunit;

namespace XUnitTestAltoValyrio.src.Inventory.Auth.Infrastructure
{
    public class AuthRespositoryTest
    {
        SQLServerRepository repository;
        UserAuthenticator authenticator;
        AuthenticateUserCommandHandler handler;


        public AuthRespositoryTest()
        {
            repository = new SQLServerRepository();
            authenticator = new UserAuthenticator(repository);
            handler = new AuthenticateUserCommandHandler(authenticator);

        }

        [Fact]
        public void InvalidUsername()
        {
            AuthenticateUserCommand command = new AuthenticateUserCommand("Jose", "123");

            Assert.Throws<InvalidAuthUsernameExeption>(
                () =>
                {
                    handler.Trigger(command);
                }
                );
        }

        [Fact]
        public void InvalidCredentials()
        {
            AuthenticateUserCommand command = new AuthenticateUserCommand("Marcos", "123");

            Assert.Throws<InvalidAuthCredentialsException>(
                () =>
                {
                    handler.Trigger(command);
                }
                );
        }

        [Fact]
        public void RegistrationPass()
        {
            AuthenticateUserCommand command = new AuthenticateUserCommand("Marcos", "hola");

            handler.Trigger(command);

            Assert.True(true);
        }

        [Fact]
        public void FindPropertie()
        {
            var auth = new User
            {
                Username = new AuthUsername("Jose").GetValue(),
                FirstName = "Culajay"
            };

            var properties = auth.GetType().GetProperties();
            string hola = String.Empty;

            foreach (var item in properties)
            {
                if (item.Name == "LastName")
                {
                    hola = item.Name;
                }
            }

            Assert.Equal("LastName", hola);
        }

        [Fact]
        public void SetPropertie()
        {
            var auth = new User
            {
                Username = new AuthUsername("Jose").GetValue(),
                LastName = "Culajay"
            };

            var properties = auth.GetType().GetProperties();

            foreach (var item in properties)
            {
                if (item.Name == "LastName")
                {
                    item.SetValue(auth, "Bailon");
                }
            }

            Assert.Equal("Bailon", auth.LastName);
        }
    }
}
