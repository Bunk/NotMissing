﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotMissing.Logging
{
    public interface ILogListener
    {
        List<ILogParent> Parents { get; set; }
        Action<object> LogFunc { get; set; }
        Levels Level { get; set; }
    }
}
