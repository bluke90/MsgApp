using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgApp_Client.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? Body { get; set; }
        public string? Token { get; set; }
        public string? Sender { get; set; }
        public string? Recipient { get; set; }
    }
}
