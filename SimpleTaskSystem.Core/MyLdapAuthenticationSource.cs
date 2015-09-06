using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using SimpleTaskSystem.MultiTenancy;
using SimpleTaskSystem.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem
{
    public class MyLdapAuthenticationSource : LdapAuthenticationSource<Tenant,User>
    {
        public MyLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
        : base(settings, ldapModuleConfig)
        {
        }
    }
}
