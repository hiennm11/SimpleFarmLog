using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog
{
    class SimpleFarmLog : ISimpleFarmLog
    {
        private readonly ILogger<SimpleFarmLog> _logger;
        private readonly IConfiguration _configuration;

        public SimpleFarmLog(ILogger<SimpleFarmLog> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void Run()
        {
            _logger.LogInformation("Hello World");
        }
    }
}
