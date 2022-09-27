using AppCusto_Viagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCusto_Viagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }

        protected override void OnAppearing()
        {
            try
            {
                lst_pedagios.ItemsSource = App.ListaPedagios;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private async void MenuItem_Clicked(object sender, EventArgs e, Pedagio pedagio_selecionado)
        {
            MenuItem disparador = (MenuItem)sender;


            bool confirmacao = await DisplayAlert("Tem Certeza?",
                                                  "Excluir pedágio " + ((Pedagio)disparador.BindingContext).Localização + "?",
                                                  "Sim", "Não");
            if (confirmacao)
            {
                App.ListaPedagios.Remove((Pedagio)disparador.BindingContext);

                lst_pedagios.ItemsSource = App.ListaPedagios;
            }
        }
    }
}