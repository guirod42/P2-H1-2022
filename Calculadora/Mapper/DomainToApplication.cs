using AutoMapper;
using Calculadora.Model;

namespace Calculadora.Mapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Atividade, AtividadeViewModel>();
        }
    }
}
