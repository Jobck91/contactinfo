﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo
{
    public class Factory
    {
        public static IContactManager CreateContactManager()
        {
            return new ContactManager();
        }
    }
}
