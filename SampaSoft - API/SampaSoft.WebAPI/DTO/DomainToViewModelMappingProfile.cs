using AutoMapper;
using AutoMapper.Configuration;
using SampaSoft.Infraestrutura.EDMX;
using SampaSoft.ViewModel.DTO;

namespace SampaSoft.WebAPI.DTO
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
