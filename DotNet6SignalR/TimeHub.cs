using Microsoft.AspNetCore.SignalR;

namespace DotNet6SignalR
{
    public class TimeHub : Hub
    {
        public async IAsyncEnumerable<DateTime> Streaming(CancellationToken cancellationToken)
        {
            while (true)
            {
                yield return DateTime.UtcNow;
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}
