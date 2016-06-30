using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMVCFE6.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var SysUsers = new List<Models.SysUser>
            {
                new Models.SysUser{UserName = "tom",Email="oiuiou",   Password = "1"},
                new Models.SysUser{UserName = "joy",Email="hkjhjkh",  Password = "2"}
            };
            SysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();


            var SysUserRole = new List<Models.SysRole>
            {
                 new Models.SysRole{RoleName = "Administrator",RoleDesc = "1"},
                 new Models.SysRole{RoleName = "guset",RoleDesc = "1"}
            };

            SysUserRole.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();



            //base.Seed(context);
        }
    }
}