using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Busca.Models;
using System.Threading.Tasks;

namespace Busca.ViewModels
{
    class TelaPessoaViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }

        public TelaPessoaViewModel(Pessoa pessoa)
        {

            Nome = pessoa.Nome;
            Email = pessoa.Email;
            Cargo = pessoa.Cargo;

        }

    }
}
