using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppCusto_Viagem.Model
{
    public class Pedagio
    {

        string _localização;
        double _valor;

        public string Localização
        {
            get => _localização;
            set
            {
                if (value == null)
                    throw new Exception("Insira a sua Localização");
                _localização = value;

            }
        }
        public double Valor
        {
            get => _valor;
            set
            {
                if (value == 0)
                    throw new Exception("Insira o valor");
                _valor = value;
            }
        }

        public string Localizacao { get; internal set; }
    }
}
