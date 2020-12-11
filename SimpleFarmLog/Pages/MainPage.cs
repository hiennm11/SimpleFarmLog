using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    public class MainPage : MenuPage
    {
        public MainPage(EasyConsole.Program program, params Option[] options)
            : base("Main Page", program,
                  new Option("Xem tất cả heo", () => program.NavigateTo<ShowAllBoar>()))
        {
        }
       
    }
}
