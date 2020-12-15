using ConsoleTables;
using SimpleFarmLog.Dtos;
using SimpleFarmLog.Entities;
using SimpleFarmLog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFarmLog.Services
{
    public interface IHerdService
    {
        List<HerdDetailDto> Herds { get; set; }
        List<BoarDetailDto> Boars { get; set; }

        int AddHerd();
        int DeteleHerd(string herdId);
        int AddBoar(string herdId, string boarId);
        int DeleteBoar(string herdId, string boarId);
        void DisplayAllBoars();
        void DisplayAllBoars(string herdId);
        void DisplayAllHerd();
    }

    public class HerdService : IHerdService
    {
        private readonly IGenericRepository<BoarHerd> _herdRepo;
        private readonly IGenericRepository<Boar> _boarRepo;
        private readonly IUnitOfWork _unitOfWork;

        public List<HerdDetailDto> Herds { get; set; }
        public List<BoarDetailDto> Boars { get; set; }

        public HerdService(IGenericRepository<BoarHerd> herdRepo, IGenericRepository<Boar> boarRepo, IUnitOfWork unitOfWork)
        {
            _herdRepo = herdRepo;
            _boarRepo = boarRepo;
            _unitOfWork = unitOfWork;
        }

        public void DisplayAllHerd()
        {
            Herds = _herdRepo.Get(orderBy: m => m.OrderBy(a => a.Number)).Select(m => new HerdDetailDto()
            {
                Id = m.Id,
                InitDate = m.InitDate,
                EndDate = m.EndDate,
                Number = m.Number
            }).ToList();

            var table = new ConsoleTable("STT", "Herd", "InitDate", "EndDate");

            Herds.ForEach(item => table.AddRow(Herds.IndexOf(item), item.Number, item.InitDate, item.EndDate));

            Console.WriteLine();
            table.Write();
            Console.WriteLine();
        }

        public int AddHerd()
        {
            var newHerd = new BoarHerd();

            var herds = _herdRepo.Get().ToList();

            var count = getMissingNumber(herds);
            if (count == herds.Count)
            {
                newHerd.Number = ++count;
            }
            else
                newHerd.Number = count;

            _herdRepo.Insert(newHerd);
            return _unitOfWork.Save();
        }

        //public int UpdateHerd(string boarId, int weight)
        //{
        //    var boar = _boarRepo.GetByID(boarId);
        //    if (boar != null)
        //    {
        //        boar.Weight = weight;
        //        return _unitOfWork.Save();
        //    }
        //    return 0;
        //}

        public int DeteleHerd(string herdId)
        {
            _herdRepo.DeleteByID(herdId);
            return _unitOfWork.Save();
        }

        static int getMissingNumber(List<BoarHerd> herds)
        {
            int n = herds.Count;
            int n_elements_sum = (n * (n + 1) / 2);
            int sum = herds.Sum(m => m.Number.Value);

            return (n_elements_sum - sum);
        }

        public int AddBoar(string herdId, string boarId)
        {
            var herd = _herdRepo.GetByID(herdId);
            if(herd != null)
            {
                var boar = _boarRepo.GetByID(boarId);

                if(herd.Boars != null)
                {
                    herd.Boars.Add(boar);
                }
                else
                {
                    herd.Boars = new List<Boar>() { boar };
                }

                return _unitOfWork.Save();
            }
            return 0;
        }

        public int DeleteBoar(string herdId, string boarId)
        {
            var herd = _herdRepo.GetByID(herdId);
            if (herd != null)
            {
                var boar = _boarRepo.GetByID(boarId);

                herd.Boars.Remove(boar);

                return _unitOfWork.Save();
            }
            return 0;
        }

        public void DisplayAllBoars()
        {           
            Boars = _boarRepo.Get(filter: a => a.Herd == null, includeProperties: "Herd").Select(m => new BoarDetailDto()
            {
                Id = m.Id,
                Color = m.Color,
                Gender = m.Gender,
                Number = m.Number,
                StartDate = m.StartDate,
                Weight = m.Weight,
                HerdNumber = m.Herd != null ? m.Herd.Number : null,
                HerdInitDate = m.Herd != null ? m.Herd.InitDate : null
            }).ToList();

            var table = new ConsoleTable("STT", "Date", "Color", "Gender", "Weight", "Herd", "Herd Date", "Herd num");

            foreach (var item in Boars)
            {
                table.AddRow(Boars.IndexOf(item), item.StartDate, item.Color, item.Gender, item.Weight, item.HerdNumber, item.HerdInitDate, item.Number);
            }

            table.Write();
            Console.WriteLine();
        }

        public void DisplayAllBoars(string herdId)
        {
            Boars = _boarRepo.Get(filter: a => a.HerdId == herdId, includeProperties: "Herd").Select(m => new BoarDetailDto()
            {
                Id = m.Id,
                Color = m.Color,
                Gender = m.Gender,
                Number = m.Number,
                StartDate = m.StartDate,
                Weight = m.Weight,
                HerdNumber = m.Herd != null ? m.Herd.Number : null,
                HerdInitDate = m.Herd != null ? m.Herd.InitDate : null
            }).ToList();

            var table = new ConsoleTable("STT", "Date", "Color", "Gender", "Weight", "Herd", "Herd Date", "Herd num");

            foreach (var item in Boars)
            {
                table.AddRow(Boars.IndexOf(item), item.StartDate, item.Color, item.Gender, item.Weight, item.HerdNumber, item.HerdInitDate, item.Number);
            }

            table.Write();
            Console.WriteLine();
        }
    }
}
