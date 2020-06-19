using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObfuscationCheckerLib
{
    interface IObfuscationChecker
    {
        bool IsObfuscated(string assemblyName);
        bool IsObfuscated(string assemblyName, string assemblyPath);
    }
}
