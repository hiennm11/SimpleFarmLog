using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Entities;
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
            var boar = new Boar() { Id = Guid.NewGuid().ToString(), Color = Enums.Color.Black, StartDate = DateTime.Now, Weight = 88 };
            var herd = new BoarHerd() {  Boars = new List<Boar>() { boar } };


            _logger.LogInformation("boar = {@boar}", herd.Boars[0]);
            _logger.LogInformation("herd {date}", herd.InitDate);
        }
    }
}
