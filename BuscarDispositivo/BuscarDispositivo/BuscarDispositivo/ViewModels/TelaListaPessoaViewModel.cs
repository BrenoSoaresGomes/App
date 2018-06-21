using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscarDispositivo.Models;

namespace BuscarDispositivo.ViewModels
{
    public class TelaListaPessoaViewModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public TelaListaPessoaViewModel()
        {
            Pessoas = new List<Pessoa>();
            Pessoas.Add(new Pessoa { Nome = "Samsung", Email = "Jose34@gmail.com", Cargo = "Gerente" });
            Pessoas.Add(new Pessoa { Nome = "Pulseira", Email = "Jose34@gmail.com", Cargo = "Gerente" });
            Pessoas.Add(new Pessoa { Nome = "Motorola", Email = "Jose34@gmail.com", Cargo = "Gerente" });
            Pessoas.Add(new Pessoa { Nome = "Sonny", Email = "Jose34@gmail.com", Cargo = "Gerente" });

            
        }

    }
}
