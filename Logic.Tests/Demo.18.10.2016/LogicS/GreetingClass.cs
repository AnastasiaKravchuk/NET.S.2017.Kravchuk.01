using System;

//path
//C:\Windows\Microsoft.NET\assembly\GAC_MSIL
//C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools
//C:\Users\MIB\Desktop\EPAM.BSU.01.2016.Lastname.01\LogicS\bin\Debug\LogicS.dll

namespace LogicS
{
    public static class GreetingClass
    {
        public static string GreetingMethod(string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (userName == string.Empty)
            {
                return "Hello, anonim!";
            }
            return $"Hello, {userName}!";
        }
    }
}
