using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtsCenterEventCalendar.Dtos;
using ArtsCenterEventCalendar.Models;
using AutoMapper;

namespace ArtsCenterEventCalendar.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           var config = new MapperConfiguration(x =>
           {
               x.CreateMap<Performance, PerformanceDto>();
               x.CreateMap<PerformanceDto, Performance>();
           });
        }
    }
}