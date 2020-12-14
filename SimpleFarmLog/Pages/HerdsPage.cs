using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    public class HerdsPage : Page
    {
        public HerdsPage(string title, EasyConsole.Program program) : base(title, program)
        {
        }

        public override void Display()
        {
            base.Display();

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
