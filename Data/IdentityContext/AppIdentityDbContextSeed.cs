using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tessa.Entities.Identity;

namespace Tessa.Data.IdentityContext
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Gio",
                    Email = "gio@me.ge",
                    UserName = "gio@me.ge",
                    Address = new Address
                    {
                        FirstName = "Gio",
                        LastName = "Datuna",
                        Street = "Vake",
                        City = "Tbilisi",
                        State = "Qartli",
                        Zipcode = "182"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
