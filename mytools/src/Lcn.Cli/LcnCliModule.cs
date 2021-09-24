using Lcn.Cli.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Lcn.Cli
{
    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(LcnCliCoreModule))]
    public class LcnCliModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<CoreBase.LcnCliCoreBaseOptions>(options => {

                options.ToolName = AppDomain.CurrentDomain.FriendlyName;
            });
        }
    }
}
