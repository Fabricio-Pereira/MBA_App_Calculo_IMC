using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_Calculo_IMC.ViewModel
{
    public class ImcViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private decimal altura;
        public decimal Altura
        {
            get { return altura; }
            set
            {
                altura = value;
                NotifyPropertyChanged(nameof(Altura));
            }
        }

        private decimal peso = 0;
        public decimal Peso
        {
            get { return peso; }
            set
            {
                peso = value;
                NotifyPropertyChanged(nameof(Peso));
            }
        }

        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set
            {
                mensagem = value;
                NotifyPropertyChanged(nameof(Mensagem));
            }
        }

        private decimal resultado = 0;
        public decimal Resultado
        {
            get { return resultado; }
            set
            {
                resultado = value;
                NotifyPropertyChanged(nameof(Resultado));
            }
        }

        public ICommand BuscarFiliaisCommand => new Command(Calcular_IMC);

        public ImcViewModel()
        {

        }

        private void Calcular_IMC()
        {
            try
            {

                if (Altura <= 0)
                {
                    Mensagem = "Não foi possivel realizar o cálculo, informe um valor maior que zero na Altura!";
                    return;
                }

                if (Peso <= 0)
                {
                    Mensagem = "Não foi possivel realizar o cálculo, informe um valor maior que zero no Peso!";
                    return;
                }

                Resultado = Math.Round(Peso / (Altura * Altura), 2);

                Resultado_Tabela_IMC();
            }
            catch (Exception ex)
            {
                Mensagem = "Erro ao Cálcular o IMC.";
            }
        }

        private void Resultado_Tabela_IMC()
        {
            var resultado = Convert.ToDouble(Resultado);

            try
            {
                if (resultado < 18.5)
                {
                    Mensagem = "Abaixo do peso";
                }
                else if (resultado >= 18.5 && resultado < 24.9)
                {
                    Mensagem = "Peso ideal";
                }
                else if (resultado >= 25 && resultado < 29.9)
                {
                    Mensagem = "Acima do peso";
                }
                else if (resultado >= 30 && resultado < 39.9)
                {
                    Mensagem = "Obesidade grau I";
                }
                else if (resultado >= 40)
                {
                    Mensagem = "Obesidade grau III";
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
