using Microsoft.AspNetCore.SignalR;

namespace DotNet6SignalR
{
    public class ChatHub: Hub
    {
        public async Task Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}
