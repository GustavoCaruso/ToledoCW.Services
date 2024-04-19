using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToledoCW.Services.Domain.Entidades;

namespace ToledoCW.Services.UnitTest.Domain.Entidades
{
    public class ClienteTest
    {
        public void Client_DeveInstanciarValido()
        {
            var _obj = new Cliente("Gustavo", new DateTime(2000, 5, 8), "gustavo@gmail.com");
            Assert.NotNull(_obj);
        }
    }
}
