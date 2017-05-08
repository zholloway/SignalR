using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR2.Controllers
{
    public class ChatroomHub : Hub
    {
        public void Send(string username, string message)
        {
            Clients.All.broadcastMessage(username, message);
        }
    }
}