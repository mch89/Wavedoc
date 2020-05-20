using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using WaveDock_Xamarin.Models;
using WaveDock_Xamarin.Repositories;
using Xamarin.Forms;

namespace WaveDock_Xamarin.ViewModels
{
    public class InfoCancionLetraViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RepoAudio repo = new RepoAudio();

        

        public Task<JsonResponse> GetCanciones()
        {
            Task<JsonResponse> Lista = repo.GetLyrics(entrada.ToString());
            return Lista;
        }

        private String _entrada;
        public String entrada
        {
            get { return this._entrada; }
            set
            {
                this._entrada = value;
                RaisePropertyChanged("entrada");
            }
        }
        public JsonResponse _tabla;
        public JsonResponse Tabla
        {
            get { return this._tabla; }
            set
            {
                this._tabla = value;
                RaisePropertyChanged("Tabla");
            }
        }

        public Command MostrarCanciones
        {
            get
            {
                
                return new Command(async () => {
                   
                    this.Tabla = await GetCanciones();
                });
            }
        }

        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
