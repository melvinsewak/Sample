using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Sample.EntityFramework;

namespace Sample.Migrator
{
    [DependsOn(typeof(SampleDataModule))]
    public class SampleMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SampleDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}