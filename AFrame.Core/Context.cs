﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Core
{
    public abstract class Context : IContext
    {
        public abstract void Dispose();
    }
}