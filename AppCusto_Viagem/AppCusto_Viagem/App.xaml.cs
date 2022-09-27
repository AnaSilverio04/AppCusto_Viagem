using AppCusto_Viagem.Model;
using AppCusto_Viagem.View;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCusto_Viagem
{
    public partial class App : Application
    {
        public static ObservableCollection<Pedagio> ListaPedagios = new ObservableCollection<Pedagio>();

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new DadosViagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
