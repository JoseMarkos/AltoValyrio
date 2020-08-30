using Alto_Valyrio.src.Inventory.Auth.Application;
using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Customers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void RegistrationPass()
        {
            var username = new AuthUsername("Marcos");
            AuthPassword password = new AuthPassword("hola");
            var repository = new SQLServerRepository();
            var authenticator = new UserAuthenticator(repository);
            authenticator.Authenticate(username, password);

            Assert.True(true);
        }

        [Fact]
        public void FindPropertie()
        {
            var auth = new Customer
            {
                Username = new AuthUsername("Jose"),
                PrimerApellido = "Culajay"
            };

            var properties = auth.GetType().GetProperties();
            string hola = String.Empty;

            foreach (var item in properties)
            {
                if (item.Name == "PrimerApellido")
                {
                    hola = item.Name;
                }
            }

            Assert.Equal("PrimerApellido", hola);
        }

        [Fact]
        public void SetPropertie()
        {
            var auth = new Customer
            {
                Username = new AuthUsername("Jose"),
                PrimerApellido = "Culajay"
            };

            var properties = auth.GetType().GetProperties();
            string hola = String.Empty;

            foreach (var item in properties)
            {
                if (item.Name == "PrimerApellido")
                {
                    item.SetValue(auth, "Bailon");
                }
            }

            Assert.Equal("Bailon", auth.PrimerApellido);
        }
    }
}
