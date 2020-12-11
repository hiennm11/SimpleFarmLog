using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarmLog
{
    class SimpleFarmLog : ISimpleFarmLog
    {
        private readonly ILogger<SimpleFarmLog> _logger;
        private readonly IConfiguration _configuration;
        private readonly IGenericRepository<Boar> _boarRepo;
        private readonly IUnitOfWork _unitOfWork;

        public SimpleFarmLog(ILogger<SimpleFarmLog> logger, IConfiguration configuration, IGenericRepository<Boar> boarRepo, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _configuration = configuration;
            _boarRepo = boarRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task Run()
        {
            //var boar = new Boar() { Id = Guid.NewGuid().ToString(), Color = Enums.Color.Black, StartDate = DateTime.Now, Weight = 88 };
            //_boarRepo.Insert(boar);
            //var row = await _unitOfWork.SaveAsync();

            //_logger.LogInformation("Init boar {id}", boar.Id);
            //_logger.LogInformation("Added boar {id}", boar.Id);
            //_logger.LogInformation("{row} affected", row);
        

            var test = await _boarRepo.GetAsync();

            foreach (var item in test)
            {
                _logger.LogInformation("boar = {@boar}", test);
            }

            
            
        }
    }
}
