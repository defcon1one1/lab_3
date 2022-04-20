using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3.Logger
{
    public interface ILogger : IDisposable
    {
        void Log(params string[] messages);
    }
}
