using Hangfire;
using System;

namespace WebDemoHangfire
{
    public class ContainerJobActivator : JobActivator
    {
        private IServiceProvider _serviceProvider;

        public ContainerJobActivator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public override object ActivateJob(Type type) => _serviceProvider.GetService(type);
    }
}
