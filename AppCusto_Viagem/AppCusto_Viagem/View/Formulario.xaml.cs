using AppCusto_Viagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCusto_Viagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e, Pedagio p, Pedagio p)
        {
            if (p is null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            try
            {
                Pedagio pedagio = new Pedagio
                {
                    Localizacao = txt_localizacao.Text,
                    Valor = Convert.ToDouble(txt_valor.Text)
                };
                App.ListaPedagios.Add(p);



                await DisplayAlert("Deu Certo!", "Pedágio Adicionado", "OK");

                await Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}