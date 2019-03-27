using Earthquakes.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earthquakes.Services
{
    public class Logger : ILogger
    {
        public void LogError(Exception exception)
        {
            var text = $"{DateTime.Now} - {exception.Message}";
        }

        public void LogMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
