using EasyConsole;
using Microsoft.Extensions.Logging;
using SimpleFarmLog.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class HerdsPage : Page
    {
        private readonly IHerdService _herdService;
        private readonly ILogger<SimpleFarmLog> _logger;

        public HerdsPage(IHerdService herdService, ILogger<SimpleFarmLog> logger, string title, EasyConsole.Program program) : base(title, program)
        {
            _herdService = herdService;         
            _logger = logger;
        }

        public override void Display()
        {
            base.Display();

            _herdService.DisplayAllHerd();

            var menu = new EasyConsole.Menu()
              .Add("Add", () => AddHerd())
              .Add("Delete", () => DeleteHerd())
              .Add("Add boar into herd", () => AddBoarToHerd())
              .Add("Delete boar from herd", () => DeleteBoarFromHerd())
              .Add("Back", () => Program.NavigateBack());

            menu.Display();

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        private void DeleteBoarFromHerd()
        {
            _herdService.DisplayAllHerd();

            int herdLength = _herdService.Herds.Count;

            var herdNumber = Input.ReadInt($"Input herd stt (between 0 and {herdLength - 1}): ", min: 0, max: herdLength - 1);

            var herdId = _herdService.Herds[herdNumber].Id;

            _herdService.DisplayAllBoars(herdId);

            int boarLength = _herdService.Boars.Count;

            var boarNumber = Input.ReadInt($"Input herd stt (between 0 and {boarLength - 1}): ", min: 0, max: boarLength - 1);

            var boarId = _herdService.Boars[boarNumber].Id;

            var confirm = Input.ReadInt("Confirm? (0: No, 1: Yes): ", min: 0, max: 1);

            if (confirm == 1)
            {
                var isSuccess = _herdService.DeleteBoar(herdId, boarId) > 0;

                if (isSuccess)
                {
                    _logger.LogInformation("Boar {boarId} has been deleted succesfully from Herd {herdId} ", boarId, herdId);
                }
                else
                    _logger.LogError("Cannot delete boar {boarId} from herd {herId}", boarId, herdId);

                Console.WriteLine();
                Input.ReadString("Press [Enter] to navigate back");
                Program.NavigateTo<HerdsPage>();
            }
            else
                Program.NavigateTo<HerdsPage>();

        }

        private void AddBoarToHerd()
        {
            _herdService.DisplayAllHerd();

            int herdLength = _herdService.Herds.Count;

            var herdNumber = Input.ReadInt($"Input herd stt (between 0 and {herdLength - 1}): ", min: 0, max: herdLength - 1);

            var herdId = _herdService.Herds[herdNumber].Id;

            _herdService.DisplayAllBoars();

            int boarLength = _herdService.Herds.Count;
                
            var boarNumber = Input.ReadInt($"Input herd stt (between 0 and {boarLength - 1}): ", min: 0, max: boarLength - 1);
                
            var boarId = _herdService.Boars[boarNumber].Id;

            var confirm = Input.ReadInt("Confirm? (0: No, 1: Yes): ", min: 0, max: 1);

            if (confirm == 1)
            {
                var isSuccess = _herdService.AddBoar(herdId, boarId) > 0;

                if (isSuccess)
                {
                    _logger.LogInformation("Boar {boarId} has been added succesfully to Herd {herdId} ", boarId, herdId);
                }
                else
                    _logger.LogError("Cannot add boar {boarId} to herd {herId}", boarId, herdId);

                Console.WriteLine();
                Input.ReadString("Press [Enter] to navigate back");
                Program.NavigateTo<HerdsPage>();
            }
            else
                Program.NavigateTo<HerdsPage>();

        }

        private void AddHerd()
        {
            var row = _herdService.AddHerd();
            if (row > 0)
            {
                _logger.LogInformation("{row} row affected", row);
                _logger.LogInformation("Added new herd");
            }
            else
                _logger.LogError("Cannot add new herd");

            Console.WriteLine();
            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateTo<HerdsPage>();
        }

        private void DeleteHerd()
        {
            int length = _herdService.Herds.Count;

            var number = Input.ReadInt($"Input stt (between 0 and {length - 1}): ", min: 0, max: length - 1);

            var id = _herdService.Herds[number].Id;

            var confirm = Input.ReadInt("Confirm? (0: No, 1: Yes): ", min: 0, max: 1);

            if (confirm == 1)
            {
                var isSuccess = _herdService.DeteleHerd(id) > 0;

                if (isSuccess)
                {
                    _logger.LogInformation("Herd {id} deleted succesfully", id);
                }
                else
                    _logger.LogError("Cannot delete herd {id}", id);

                Console.WriteLine();
                Input.ReadString("Press [Enter] to navigate back");
                Program.NavigateTo<HerdsPage>();
            }
            else
                Program.NavigateTo<HerdsPage>();
        }
       
    }
}
