// See https://aka.ms/new-console-template for more 



using Microsoft.EntityFrameworkCore;
using MsgApp_Server.Data;
using MsgApp_Server.Models;
using MsgApp_Server.Services;
using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
  







//NetService Net = new NetService();

public class Services{
    public NetService NetService { get; private set; }
    public Services()
    {
        NetService = new NetService();
    }
}

//Task.Run(() => Net.StartListening());
Net.StartListening();

/*
Message msg = new Message
{
    Body = "test",
    Recipient = "1254",
    Sender = "5431",
    Token = "asfd543a2sd1f"
};

var _context = new DataContext();

_context.Messages.Add(msg);
_context.SaveChanges();

Message newmsg = _context.Messages.FirstOrDefault(m => m.Sender == "5431");
Console.WriteLine(newmsg.Body);

using (var ms = new MemoryStream())
{
    string jsonString = JsonSerializer.Serialize(msg);
    Console.WriteLine(jsonString);
    byte[] vs = Encoding.ASCII.GetBytes(jsonString);
    Console.WriteLine(vs);
}
*/
