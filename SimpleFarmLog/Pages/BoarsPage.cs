using ConsoleTables;
using EasyConsole;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using SimpleFarmLog.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class BoarsPage : Page
    {
        private readonly IBoarService _boarService;

        public BoarsPage(IBoarService boarService, EasyConsole.Program program, params Option[] options) 
            : base("All boar", program)
        {           
            _boarService = boarService;
        }

        
        public override void Display()
        {
            base.Display();

            _boarService.DisplayAllBoars();

            var menu = new EasyConsole.Menu()
              .Add("Add", () => Program.NavigateTo<BoarEntryPage>())
              .Add("Edit", () => Program.NavigateTo<BoarEditPage>())
              .Add("Delete", () => Program.NavigateTo<BoarDeletePage>())
              .Add("Back", () => Program.NavigateBack());
                
            menu.Display();

            Console.WriteLine();                     

        }
    }
}
