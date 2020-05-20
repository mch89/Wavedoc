using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WaveDock_Xamarin.Models;
using WaveDock_Xamarin.Repositories;
using Xamarin.Forms;

namespace WaveDock_Xamarin.ViewModels
{
    class InfoCancionAudioView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public RepoAudio repo = new RepoAudio();

        public JsonResponseAudio GetInfoAudio()
        {
            JsonResponseAudio Lista = repo.GetInfoFromAudio();
            return Lista;
        }

       
        public JsonResponseAudio _tabla;
        public JsonResponseAudio Tabla
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

                return new Command(() => {

                    this.Tabla = GetInfoAudio();
                });
            }
        }

        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
