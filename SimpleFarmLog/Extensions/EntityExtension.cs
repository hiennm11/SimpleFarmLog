using SimpleFarmLog.Dtos;
using SimpleFarmLog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFarmLog.Extensions
{
    public static class EntityExtension
    {
        public static List<BoarDetailDto> MapToListDetail(this IEnumerable<Boar> boars)
        {
            return boars.Select(m => new BoarDetailDto()
            {
                Id = m.Id,
                Color = m.Color,
                Gender = m.Gender,
                Number = m.Number,
                StartDate = m.StartDate,
                Weight = m.Weight,
                HerdNumber = m.Herd !=null ? m.Herd.Number : null,
                HerdInitDate = m.Herd != null ? m.Herd.InitDate : null
            }).ToList();
        }

        public static Boar MapEntryToEntities(this BoarEntryDto dto)
        {
            return new Boar()
            {
                StartDate = dto.StartDate,
                Color = dto.Color,
                Gender = dto.Gender,
                Weight = dto.Weight,
                Number = dto.Number
            };
        }
    }
}
