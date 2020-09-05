using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Applications
{
    public sealed class UserAuthenticator
    {
        private readonly IAuthRepository Repository;

        public UserAuthenticator(IAuthRepository repository)
        {
            this.Repository = repository;
        }

        public void Authenticate(AuthUsername username, AuthPassword password)
        {
            var auth = Repository.Search(username);
            EnsureUserExist(auth, username);
            EnsureCredentialsAreValid(auth, password);
        }
#nullable enable
        private void EnsureUserExist(AuthUser? auth, AuthUsername username)
        {
            if (auth is null)
            {
                throw new InvalidAuthUsernameExeption(username);
            }
        }
#nullable disable

        private void EnsureCredentialsAreValid(AuthUser auth, AuthPassword password)
        {
            if (!auth.PasswordMatches(password))
            {
                throw new InvalidAuthCredentialsException(auth.GetUserName());
            }
        }
    }
}
