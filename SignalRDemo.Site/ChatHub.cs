using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Site
{
    /// <summary>
    /// 聊天室Hub
    /// </summary>
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);

            //推送消息到指定客户端
            //var connectionId = "";
            //Clients.Client(connectionId).broadcastMessage(name, message);

        }
    }
}