using DAL.DTO;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleArchitecutre2.Mapping
{
    public class Mappings
    {
        public static void config()
        {
            AutoMapper.Mapper.CreateMap<UserModel, UserModelDTO>()
            .ForMember(g => g.Id, map => map.MapFrom(vm => vm.Id))
            .ForMember(g => g.Username, map => map.MapFrom(vm => vm.Username))
            .ForMember(g => g.Password, map => map.MapFrom(vm => vm.Password))
            .ForMember(g => g.CRN, map => map.MapFrom(vm => vm.CRN))
            .ForMember(g => g.Phone, map => map.MapFrom(vm => vm.Phone))
            .ForMember(g => g.created_at, map => map.MapFrom(vm => vm.created_at))
            .ForMember(g => g.updated_at, map => map.MapFrom(vm => vm.updated_at));

            AutoMapper.Mapper.CreateMap<UserModelDTO, UserModel>()
              .ForMember(g => g.Id, map => map.MapFrom(vm => vm.Id))
              .ForMember(g => g.Username, map => map.MapFrom(vm => vm.Username))
              .ForMember(g => g.Password, map => map.MapFrom(vm => vm.Password))
              .ForMember(g => g.CRN, map => map.MapFrom(vm => vm.CRN))
              .ForMember(g => g.Phone, map => map.MapFrom(vm => vm.Phone))
              .ForMember(g => g.created_at, map => map.MapFrom(vm => vm.created_at))
              .ForMember(g => g.updated_at, map => map.MapFrom(vm => vm.updated_at));
        }
    }
}