using ConsoleTables;
using EasyConsole;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFarmLog.Pages
{
    public class ShowAllBoar : Page
    {
        private readonly IGenericRepository<Boar> _boarRepo;

        public ShowAllBoar(IGenericRepository<Boar> boarRepo, EasyConsole.Program program, params Option[] options) : base("Xem tất cả heo", program)
        {
            _boarRepo = boarRepo;
        }

        public override void Display()
        {
            base.Display();
            var boars = _boarRepo.Get();
           
            var table = ConsoleTable.From(boars);

            table.Write();
            Console.WriteLine();

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
