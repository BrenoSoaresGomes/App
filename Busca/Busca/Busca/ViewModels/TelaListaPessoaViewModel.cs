using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Busca.Models;
using System.Threading.Tasks;

namespace Busca.ViewModels
{
    class TelaListaPessoaViewModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public TelaListaPessoaViewModel()
        {
            Pessoas = new List<Pessoa>();
            Pessoas.Add(new Pessoa { Nome = "Marcus", Email = "Marcus_Vinicius@yahoo.com", Cargo = "(27) 99397-1258" });
            Pessoas.Add(new Pessoa { Nome = "Matheus", Email = "TodyNescMn@outlook.com", Cargo = "(27) 99534-7408" });
            Pessoas.Add(new Pessoa { Nome = "Fernanda", Email = "Fê2013@hotmail.com", Cargo = "(27) 99725-1719" });
            Pessoas.Add(new Pessoa { Nome = "Chequetto", Email = "Chequetto_Mec@gmail.com", Cargo = "(27) 99854-4360" });
        }

    }
}
