﻿using Abp.MultiTenancy;
using SimpleTaskSystem.Users;

namespace SimpleTaskSystem.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {
        protected Tenant()
        {

        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
