using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance
{
    public sealed class SQLServerRepository : IUserRepository
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

                var list = new List<User>();
                list.Add(matches.FirstOrDefault());
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void Save(User user)
        {
            using var context = new AltoTestContext();

            try
            {
                context.Users.Add(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
