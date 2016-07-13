using CustomIdentity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.EFContext
{
    public class AppIdentityDbContext : IdentityDbContext<ShopUser>
    {
        public AppIdentityDbContext() : base("Shop"){ }

        static AppIdentityDbContext()
        {
            Database.SetInitializer<AppIdentityDbContext>(new IdentityDbInit());
        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }       
    }
}
