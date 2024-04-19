using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToledoCW.Services.Domain.Entidades;
using ToledoCW.Services.Infraestructure.Repositorios;
using ToledoCW.Services.Services;

namespace ToledoCW.Services.Application.Services
{
    public class ClienteService : ServiceBase<Cliente>
    {
        public ClienteService(IServiceProvider serviceProvider, IRepositorioBase<Cliente> repositorio) : base(serviceProvider, repositorio)
        {
        }
    }
}
