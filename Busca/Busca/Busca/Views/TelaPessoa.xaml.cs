using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Busca.Models;
using Busca.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Busca.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaPessoa : ContentPage
    {
        public  TelaPessoa(Pessoa pessoa)
        {
            InitializeComponent();

            BindingContext = new TelaPessoaViewModel(pessoa);

        }
    }
}
