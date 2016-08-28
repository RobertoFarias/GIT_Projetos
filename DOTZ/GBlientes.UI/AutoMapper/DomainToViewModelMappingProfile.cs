using AutoMapper;
using GBlientes.UI.ViewModels;
using GClientes.Domain.Entities;

namespace GBlientes.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }



        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<SaldoViewModel, Saldo>();

        }
    }

    
}