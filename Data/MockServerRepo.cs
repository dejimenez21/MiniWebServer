using System.Collections.Generic;
using Http_Server.Models;

namespace Http_Server.Data
{
    public class MockServerRepo : IServerRepo
    {
        public void CreateMessage(Message msg)
        {
            DataBase.SaveNewMessage(msg);
        }

        public IEnumerable<Message> GetAllMessages()
        {
            return DataBase.messages;
        }
    }
}