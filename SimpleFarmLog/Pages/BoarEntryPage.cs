using EasyConsole;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Dtos;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using SimpleFarmLog.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class BoarEntryPage : Page
    {
        private readonly IBoarService _boarService;
        private readonly ILogger<SimpleFarmLog> _logger;

        public BoarEntryPage(IBoarService boarService, ILogger<SimpleFarmLog> logger, EasyConsole.Program program) : base("Add boar", program)
        {
            _boarService = boarService;
            _logger = logger;
        }
                 
        public override void Display()
        {
            base.Display();

            _boarService.DisplayAllBoars();

            var boar = new BoarEntryDto()
            {
                Color = Input.ReadEnum<Enums.Color>("Input color (0: Black; 1: Tripped): "),
                Gender = Input.ReadEnum<Enums.Gender>("Input gender (0: Male; 1: Female): "), 
                Number = Input.ReadInt("Input number (between 0 and 15): ", min: 0, max: 15),
                Weight = Input.ReadInt("Input weight (between 0 and 300): ", min: 0, max: 300)
            };

            var row = _boarService.AddBoar(boar);

            if(row > 0)
            {
                _logger.LogInformation("{row} row affected", row);
                _logger.LogInformation("Added boar {@boar}", boar);
            }
            else
                _logger.LogError("Cannot add {@boar}", boar);

            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
     
    }
}
