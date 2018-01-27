using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Events
{
    public class SpeechBubble : IApplicationEvent
    {
        public string Text { get; set; }
    }
}
