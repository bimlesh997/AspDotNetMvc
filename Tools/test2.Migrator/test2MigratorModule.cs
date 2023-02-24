using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using test2.EntityFramework;

namespace test2.Migrator
{
    [DependsOn(typeof(test2DataModule))]
    public class test2MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<test2DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}