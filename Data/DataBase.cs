using Http_Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace Http_Server.Data
{
    public static class DataBase
    {
        public static List<Message> messages;
        public static int IdCounter;

        public static void StartDataBase()
        {
            messages = new List<Message>{
                new Message{Id=1, Body="Hola"},
                new Message{Id=2, Body="Mundo"}
            };

            IdCounter = 2;
        }

        public static void CreateMessage(Message msg)
        {
            IdCounter++;
            msg.Id = IdCounter;
            messages.Add(msg);
        }


    }
}