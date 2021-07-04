using AutoMapper;
using Booksuggestion.API.Dtos;
using Booksuggestion.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksuggestion.API.Helpers
{
    public class AutoMappersProfiles:Profile
    {
        public AutoMappersProfiles()
        {
            CreateMap<Book, BookForListDto>();
            CreateMap<Book, BookForDetailDto>();
        }
    }
}
