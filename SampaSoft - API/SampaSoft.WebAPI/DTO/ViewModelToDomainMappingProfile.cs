using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SampaSoft.Infraestrutura.EDMX;
using SampaSoft.ViewModel.DTO;

namespace SampaSoft.WebAPI.DTO
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}