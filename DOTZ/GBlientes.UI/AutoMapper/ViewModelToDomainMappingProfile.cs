using AutoMapper;
using GBlientes.UI.ViewModels;
using GClientes.Domain.Entities;

namespace GBlientes.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<Saldo, SaldoViewModel>();

        }

     
    }
}