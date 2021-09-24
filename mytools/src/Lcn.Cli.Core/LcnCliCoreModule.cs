using System;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Lcn.Cli.Core.Commands;
using Lcn.Cli.CoreBase;

namespace Lcn.Cli.Core
{

    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(LcnCliCoreBaseModule))]
    public class LcnCliCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<LcnCliCoreBaseOptions>(options => {

                options.Commands["test"] = typeof(MyTestCommand);
            });
        }
    }
}
