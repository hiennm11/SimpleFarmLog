using EasyConsole;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class BoarDeletePage : Page
    {
        private readonly IBoarService _boarService;
        private readonly ILogger<SimpleFarmLog> _logger;

        public BoarDeletePage(IBoarService boarService, ILogger<SimpleFarmLog> logger, string title, EasyConsole.Program program) : base(title, program)
        {
            _boarService = boarService;
            _logger = logger;
        }

        public override void Display()
        {
            base.Display();

            _boarService.DisplayAllBoars();

            int length = _boarService.Boars.Count;

            var number = Input.ReadInt($"Input stt (between 0 and {length - 1}): ", min: 0, max: length - 1);

            var id = _boarService.Boars[number].Id;

            var confirm = Input.ReadInt("Confirm? (0: No, 1: Yes): ", min: 0, max: 1);

            if(confirm == 1)
            {
                var isSuccess = _boarService.DeteleBoar(id) > 0;

                if (isSuccess)
                {
                    _logger.LogInformation("Boar {id} weight deleted", id);
                }
                else
                    _logger.LogError("Cannot delete boar {id}", id);

                Input.ReadString("Press [Enter] to navigate back");
                Program.NavigateBack();
            }
            else
                Program.NavigateBack();
        }
    }
}
