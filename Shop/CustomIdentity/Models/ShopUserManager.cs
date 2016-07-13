using CustomIdentity.EFContext;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.Models
{
    public class ShopUserManager : UserManager<ShopUser>
    {
        public ShopUserManager(IUserStore<ShopUser> store) : base(store){ }

        public static ShopUserManager Create(IdentityFactoryOptions<ShopUserManager> options,IOwinContext context)
        {
            AppIdentityDbContext db = context.Get<AppIdentityDbContext>();
            ShopUserManager manager = new ShopUserManager(new UserStore<ShopUser>(db));
            return manager;
        }
    }
}
