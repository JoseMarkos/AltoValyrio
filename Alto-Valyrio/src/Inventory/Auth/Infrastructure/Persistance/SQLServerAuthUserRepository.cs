using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Linq;

namespace Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance
{
    public class SQLServerAuthUserRepository : IAuthRepository
    {
#nullable enable
        public AuthUser? Search(AuthUsername username)
        {
            using var context = new AltoTestContext();
            try
            {
                var user = context.Users
                        .Where(b => b.Username == username.GetValue())
                        .FirstOrDefault();

                var authUsername = new AuthUsername(user.Username);
                var authPassword = new AuthPassword(user.Password);

                return new AuthUser(authUsername, authPassword);

            }
            catch (Exception)
            {
                return null;
            }
        }
#nullable disable
    }
}
