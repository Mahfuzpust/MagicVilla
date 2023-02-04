﻿using AutoMapper;
using MagicVilla_API.Models.DTO;
using MagicVilla_API.Models;
using MagicVilla_VillaAPI.Models.DTO;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}