using ObfuscationCheckerLib.Checkers.ConfuserEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObfuscationCheckerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfuserExChecker confuserExChecker = new ConfuserExChecker();
            //var isObfuscated = confuserExChecker.IsObfuscated("CommonDtmPresenter.dll", @"E:\Confused");
            confuserExChecker.ScanAssemblies(@"C:\Users\vinoj\source\repos\RnD\TestLibrary\bin\Debug\Confused");
        }
    }
}
