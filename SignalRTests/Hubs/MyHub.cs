using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRTests.Hubs
{
    public class MyHub : Hub
    {
        public void Hello(string message)
        {
            Clients.Client(Context.ConnectionId).hello(message+ " "+ "C#");
        }
        
    }
}