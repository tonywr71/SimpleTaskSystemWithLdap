using System.Reflection;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Ldap.Configuration;

namespace SimpleTaskSystem
{
    /// <summary>
    /// 'Core module' for this project.
    /// </summary>
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class SimpleTaskSystemCoreModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.Modules.ZeroLdap().Enable(typeof(MyLdapAuthenticationSource));
        }
        public override void Initialize()
        {
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
