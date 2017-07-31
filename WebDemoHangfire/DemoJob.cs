using System;

namespace WebDemoHangfire
{
    public class DemoJob
    {
        private ILogger logger;

        public DemoJob(ILogger logger)
        {
            this.logger = logger;
        }

        public void Execute() => logger.WriteLine($"DemoJob: {DateTime.Now}");
    }
}
