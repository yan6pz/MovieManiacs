using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using MovieManiacs.Models;

namespace MovieManiacs
{
    public class ChatHub : Hub
    {

        static List<User> ConnectedUsers = new List<User>();
        static List<Message> CurrentMessage = new List<Message>();

        public void Connect(string userName)
        {

            var id = Context.ConnectionId;

            if (ConnectedUsers.Count(x => x.Id == id) == 0)
            {

                ConnectedUsers.Add(new User { Id = id, Name = userName });

                // send to caller
                Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);

                // send to all except caller client
                Clients.AllExcept(id).onNewUserConnected(id, userName);

            }

        }
        public void SendMessageToAll(string userName, string message)
        {

            Clients.All.messageReceived(userName, message);
        }

        public void SendPrivateMessage(string toUserId, string message)
        {

            string fromUserId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.Id == toUserId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.Id == fromUserId);

            if (toUser != null && fromUser != null)
            {
                // send to 
                Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.Name, message);

                // send to caller user
                Clients.Caller.sendPrivateMessage(toUserId, fromUser.Name, message);
            }

        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.Id == Context.ConnectionId);
            if (item != null)
            {
                ConnectedUsers.Remove(item);

                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.Name);

            }

            return base.OnDisconnected(stopCalled);
        }

    }
}