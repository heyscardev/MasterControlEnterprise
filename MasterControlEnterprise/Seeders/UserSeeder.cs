using MasterControlEnterprise.Model;
using MasterControlEnterprise.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Seeders
{
    public class UserSeeder
    {
        public DataContext db;
        public UserSeeder()
        {
            this.db = new DataContext();
            Seed("balto", "perez", IdentificationType.V, "12431243", UserType.MANAGER, "user1", "miguel123", "chavez124@gmail.com");
            Seed("yefree", "castrol", IdentificationType.V, "23425434", UserType.MANAGER, "user6", "miguel123", "chavez124@gmail.com");
            Seed("pedro", "adams", IdentificationType.V, "423425", UserType.ADMIN, "user2", "miguel123", "chavez124@gmail.com");
            Seed("castri", "petroleo", IdentificationType.V, "352532", UserType.MANAGER, "user3", "miguel123", "chavez124@gmail.com");
            Seed("feet", "damasco", IdentificationType.J, "5452223", UserType.SELLER, "user4", "miguel123", "chavez124@gmail.com");
            Seed("bad", "bunnie", IdentificationType.E, "42646525", UserType.SELLER, "user5", "miguel123", "chavez124@gmail.com");
            db.SaveChanges();
        }
        private void Seed(string firstName,string lastName,IdentificationType identificationType, string identityDocument,
            UserType userType,string userName,string password,
            string email)
        {
            User u = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                IdentificationType = identificationType,
                IdentityDocument = identityDocument,
                UserName = userName,
                Password = password,
                UserType = userType,
                Email = email,
                DeleteState = false
            };
            this.db.Users.Add(u);
        }
    }
}
