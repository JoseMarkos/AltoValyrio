using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance
{
    public sealed class SQLServerUsersRepository : IUserRepository
    {

        public ICollection<User> Matching(string criteria)
        {
            using var context = new AltoTestContext();

            try
            {
                var matches = from user in context.Users
                              where user.Username == criteria
                              select user
                              ;

                return matches.ToList(); ;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void Save(User user)
        {
            using var context = new AltoTestContext();

            context.Users.Add(user);
            context.SaveChanges();
        }

        public ICollection<User> SearchAll()
        {
            using var context = new AltoTestContext();

            try
            {
                var matches = context.Users.ToList();

                return matches;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
