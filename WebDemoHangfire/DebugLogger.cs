using System.Diagnostics;

namespace WebDemoHangfire
{
    public class DebugLogger : ILogger
    {
        public void WriteLine(string message) => Debug.WriteLine(message);
    }
}
