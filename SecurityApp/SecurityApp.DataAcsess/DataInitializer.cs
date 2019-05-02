using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SecurityApp.Services;

namespace SecurityApp.DataAcsess
{
    class DataInitializer : CreateDatabaseIfNotExists<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            context.Users.Add(new Models.User
            {
                Login = "Admin",
                Password = CryptoService.HashPassword("123")
            });
        }
    }
}
