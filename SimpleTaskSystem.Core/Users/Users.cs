using Abp.Authorization.Users;
using SimpleTaskSystem.MultiTenancy;

namespace SimpleTaskSystem.Users
{
    public class User : AbpUser<Tenant, User>
    {
        public override string ToString()
        {
            return string.Format("[User {0}] {1}", Id, UserName);
        }
    }
}
