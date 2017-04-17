using Microsoft.AspNet.SignalR;

namespace SignalRTests.Hubs
{
    public class MyHub : Hub
    {
        public void Hello(string message)
        {
            Clients.All.hello(message);
        }
    }
}