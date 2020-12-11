using EasyConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    class InputPage : MenuPage
    {
        public InputPage(EasyConsole.Program program) : base("Input", program)
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
