using System.Collections.Generic;
using Http_Server.Models;

namespace Http_Server.Data
{
    public class MockServerRepo : IServerRepo
    {
        public void CreateMessage(Message msg)
        {
            DataBase.CreateMessage(msg);
        }

        public void DeleteMessage(int id)
        {
            DataBase.messages.RemoveAll(x=>x.Id==id);
        }

        public IEnumerable<Message> GetAllMessages()
        {
            return DataBase.messages;
        }

        public void UpdateMessage(Message msg)
        {
            DataBase.messages.Find(x=>x.Id==msg.Id).Body = msg.Body;
        }

        
    }
}