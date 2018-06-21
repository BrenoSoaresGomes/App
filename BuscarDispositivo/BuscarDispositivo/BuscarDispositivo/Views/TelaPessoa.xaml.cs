using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscarDispositivo.Models;
using BuscarDispositivo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuscarDispositivo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaPessoa : ContentPage
    {
        public TelaPessoa()
        {
            InitializeComponent();

            BindingContext = new TelaPessoaViewModel();
        }
    }
}
