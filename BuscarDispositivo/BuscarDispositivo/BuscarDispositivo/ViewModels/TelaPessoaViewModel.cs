using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscarDispositivo.Models;

namespace BuscarDispositivo.ViewModels
{
    class TelaPessoaViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }

        public TelaPessoaViewModel()
        {
            Pessoa pessoa = PegarPessoa();
            Nome = pessoa.Nome;
            Email = pessoa.Email;
            Cargo = pessoa.Cargo;



        }

        public Pessoa PegarPessoa()
        {
           return new Pessoa { Nome = "José Carlos", Email = "Jose34@gmail.com", Cargo = "Gerente" };
            
        }

    }
}
