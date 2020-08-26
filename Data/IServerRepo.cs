using System.Collections.Generic;
using Http_Server.Models;

namespace Http_Server.Data
{
    public interface IServerRepo
    {
        IEnumerable<Message> GetAllMessages();
        void CreateMessage(Message msg);
        void UpdateMessage(Message msg);
    }
}