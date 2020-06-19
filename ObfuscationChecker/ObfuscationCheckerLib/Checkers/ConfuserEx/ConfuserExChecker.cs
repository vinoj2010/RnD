using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Practices.Unity.Utility;
using System.IO.SafeTraversal;
using System.Threading.Tasks;

namespace ObfuscationCheckerLib.Checkers.ConfuserEx
{
    public class ConfuserExChecker : IObfuscationChecker
    {
        public bool IsObfuscated(string assemblyName)
        {
            bool isObfuscated = false;
            Assembly loadedAssembly = Assembly.Load(new AssemblyName(assemblyName));
            foreach (var type in loadedAssembly?.GetTypes())
            {
               
            }
            return isObfuscated;
        }

        public bool IsObfuscated(string assemblyName, string assemblyPath)
        {
            bool isObfuscated = false;
            var assemblyFullPath = Path.Combine(assemblyPath, assemblyName);
            if (File.Exists(assemblyFullPath))
            {
                Assembly loadedAssembly = Assembly.LoadFile(assemblyFullPath);
                //TODO: Handle the System.Reflection.ReflectionTypeLoadException
                //loadedAssembly.GetCustomAttributes().
                isObfuscated = true;
            }
            return isObfuscated;
        }

        public void ScanAssemblies(string scanPath)
        {
            IList<string> scanPathList = new List<string>() { @"D:\", @"E:\" };
            ObfuscationValidator validator;
            foreach (var path in scanPathList)
            {
                //
                validator = new ObfuscationValidator(path);
                validator.ValidateAsync();
            }
        }
    }
}
