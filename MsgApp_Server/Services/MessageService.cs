using MsgApp_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MsgApp_Server.Services {
    
    public static class MessageService {
        public static void ProcessIncomingPacket(string data)
        {
            // Get string from bytes
            //var strData = Encoding.ASCII.GetString(data, 0, data.Length);
            // Deserialize string to Message obj
            Message message = JsonSerializer.Deserialize<Message>(data);
            // Store Message in local db
            var _context = new Data.DataContext();
            _context.Messages.Add(message);
            _context.SaveChanges();
            Console.WriteLine(message.Body);
            Console.WriteLine(message.Sender);
        }
        public static void ProcessOutboundPacket(this Message message)
        {
            // Convert Message obj to json string
            byte[] packet;
            var jsonString = JsonSerializer.Serialize(message);
            // Convert json string to byte array
            packet = Encoding.ASCII.GetBytes(jsonString);

        }

        public static void Send(this Message message) {

        }
        public static void Receive(this Message message) {
        }
    }

}
