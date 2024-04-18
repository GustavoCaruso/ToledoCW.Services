using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToledoCW.Services.Infraestructure.Entidades;

namespace ToledoCW.Services.UnitTest.Domain.Entidades
{
    public class AtendenteTest
    {
        [Fact]
        public void EhValido_DeveValidarInstancia()
        {
            //Arrange
            var _obj = new Atendente();
            _obj.Nome = "Gustavo";
            _obj.Estabelecimento = 1;

            //Act
            var _result = _obj.EhValido();

            //Assert
            Assert.True(_result );
        }
    }
}
