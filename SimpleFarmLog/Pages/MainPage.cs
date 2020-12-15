using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(EasyConsole.Program program, params Option[] options)
            : base("Main Page", program,
                  new Option("All boar", () => program.NavigateTo<BoarsPage>()),
                  //new Option("Input", () => program.NavigateTo<InputPage>()),
                  //new Option("Add boar", () => program.NavigateTo<BoarEntryPage>()),
                  new Option("All herd", () => program.NavigateTo<HerdsPage>()))
        {
        }
       
    }
}
