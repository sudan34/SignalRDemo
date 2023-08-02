using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Models;

namespace SignalRDemo.Hubs
{
    public class NotificationHub : Hub
    {
        // public async Task SendMessage(string message)
        // {
        //     await Clients.All.SendAsync("ReceiveMsg",message);
        // }

        public override Task OnConnectedAsync()
        {
            ConnectedUser.UserId.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            ConnectedUser.UserId.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
