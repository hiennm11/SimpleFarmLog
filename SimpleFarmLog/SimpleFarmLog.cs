using ConsoleTables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Pages;
using SimpleFarmLog.Repositories;
using SimpleFarmLog.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFarmLog
{
    class SimpleFarmLog : EasyConsole.Program 
    {
        public SimpleFarmLog(ILogger<SimpleFarmLog> logger,            
            IBoarService boarService, 
            IHerdService herdService,
            IUnitOfWork unitOfWork)
            : base("My Family Farm Log", breadcrumbHeader: true)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AddPage(new MainPage(this));
            AddPage(new InputPage(this));
            AddPage(new BoarsPage(boarService, this));
            AddPage(new BoarEntryPage(boarService, logger, this));
            AddPage(new BoarEditPage(boarService, logger, "Boar Edit Page", this));
            AddPage(new BoarDeletePage(boarService, logger, "Delete Boar", this));
            AddPage(new HerdsPage(herdService, logger, "All herd", this));

            SetPage<MainPage>();
        }

        //private readonly ILogger<SimpleFarmLog> _logger;
        //private readonly IConfiguration _configuration;
        //private readonly IGenericRepository<Boar> _boarRepo;
        //private readonly IUnitOfWork _unitOfWork;

        //public SimpleFarmLog(ILogger<SimpleFarmLog> logger, IConfiguration configuration, IGenericRepository<Boar> boarRepo, IUnitOfWork unitOfWork)
        //{
        //    _logger = logger;
        //    _configuration = configuration;
        //    _boarRepo = boarRepo;
        //    _unitOfWork = unitOfWork;
        //}

        //public async Task Run()
        //{
        //    ////var boar = new Boar() { Id = Guid.NewGuid().ToString(), Color = Enums.Color.Black, StartDate = DateTime.Now, Weight = 88 };
        //    ////_boarRepo.Insert(boar);
        //    ////var row = await _unitOfWork.SaveAsync();

        //    ////_logger.LogInformation("Init boar {id}", boar.Id);
        //    ////_logger.LogInformation("Added boar {id}", boar.Id);
        //    ////_logger.LogInformation("{row} affected", row);
        

        //    //var boars = await _boarRepo.GetAsync();

        //    ////foreach (var item in test)
        //    ////{
        //    ////    _logger.LogInformation("boar = {@boar}", test);
        //    ////}

        //    //var table = ConsoleTable.From(boars);
            
        //    //table.Write();
        //    //Console.WriteLine();

        //    ////var rows = Enumerable.Repeat(new Something(), 10);

        //    ////ConsoleTable
        //    ////    .From<Something>(rows)
        //    ////    .Configure(o => o.NumberAlignment = Alignment.Right)
        //    ////    .Write(Format.Alternative);

        //}
    }
}
