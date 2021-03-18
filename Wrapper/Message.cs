using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wrapper
{
    public class Message
    {

        public int MessageId { get; set; }
        public string MessageLanguage { get; set; }
        public string MessageText { get; set; }
        public string CustomId { get; set; }
    }
}