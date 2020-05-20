using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WaveDock_Xamarin.Repositories;

namespace WaveDock_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusquedaAudio2 : ContentPage
    {
        RepoAudio repo;
        public BusquedaAudio2()
        {
            InitializeComponent();
            repo = new RepoAudio();
        }

        private async void Button_Clicked_Clicked(object sender, EventArgs e)
        {
            var file =  await CrossFilePicker.Current.PickFile();

            if (file != null)
                {
                    lbl.Text =  file.FileName;
                 var x =  await repo.PruebaEnvioAudioAsync(file);
                }
        }

    }
}