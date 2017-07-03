using System;

namespace Logic
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
