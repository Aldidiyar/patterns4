﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns4
{
    internal class WhatsappNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Whatsapp notification");
        }
    }
}
