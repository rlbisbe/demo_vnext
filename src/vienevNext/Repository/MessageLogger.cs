using System;
using Microsoft.AspNet.Builder;
using System.Diagnostics;

namespace WebApplication1.Repository
{
    public interface IMessageLogger
    {
        void Log(string message);
    }

    public class MessageLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
