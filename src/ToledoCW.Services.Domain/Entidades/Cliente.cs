using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToledoCW.Services.Domain.Entidades
{
    public class Cliente
    {
        public Cliente(string nome, DateTime dataNascimento, string email)
        {

            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;

        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; }
        public string Email { get; set; }
        public long Id { get; set; }
    }
}
