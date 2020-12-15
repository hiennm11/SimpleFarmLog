using ConsoleTables;
using SimpleFarmLog.Dtos;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Extensions;
using SimpleFarmLog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFarmLog.Services
{
    public interface IBoarService
    {
        List<BoarDetailDto> Boars { get; set; }
        void DisplayAllBoars();
        int AddBoar(BoarEntryDto boarEntry);
        int UpdateWeight(string boarId, int weight);
        int DeteleBoar(string boarId);
    }

    public class BoarService : IBoarService
    {
        private readonly IGenericRepository<Boar> _boarRepo;
        private readonly IUnitOfWork _unitOfWork;

        public List<BoarDetailDto> Boars { get; set; }

        public BoarService(IGenericRepository<Boar> boarRepo, IUnitOfWork unitOfWork) 
        {
            _boarRepo = boarRepo;
            _unitOfWork = unitOfWork;
        }

        public void DisplayAllBoars()
        {
            Boars = _boarRepo.Get(includeProperties: "Herd").MapToListDetail();          

            var table = new ConsoleTable("STT", "Date", "Color", "Gender", "Weight", "Herd", "Herd Date", "Herd num");

            foreach (var item in Boars)
            {
                table.AddRow(Boars.IndexOf(item), item.StartDate, item.Color, item.Gender, item.Weight, item.HerdNumber, item.HerdInitDate, item.Number);               
            }

            Console.WriteLine();
            table.Write();
            Console.WriteLine();
        }

        public int AddBoar(BoarEntryDto boarEntry)
        {
            var newBoar = boarEntry.MapEntryToEntities();
            _boarRepo.Insert(newBoar);
            return _unitOfWork.Save();
        }

        public int UpdateWeight(string boarId, int weight)
        {
            var boar = _boarRepo.GetByID(boarId);
            if(boar != null)
            {
                boar.Weight = weight;
                return _unitOfWork.Save();
            }
            return 0;
        }

        public int DeteleBoar(string boarId)
        {
            _boarRepo.DeleteByID(boarId);
            return _unitOfWork.Save();
        }

    }
}
