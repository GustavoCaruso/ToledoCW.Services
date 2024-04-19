using ToledoCW.Services.Infraestructure.Entidades;
using ToledoCW.Services.Infraestructure.Repositorios;

namespace ToledoCW.Services.Services;

public class EstabelecimentoService : ServiceBase<Estabelecimento>, IEstabelecimentoService
{
    public EstabelecimentoService(IServiceProvider serviceProvider, IRepositorioBase<Estabelecimento> repo) : base(serviceProvider, repo)
    {
    }
}

public interface IEstabelecimentoService : IService<Estabelecimento>
{
}