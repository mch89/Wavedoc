using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using nuevas
using System.Collections.ObjectModel;
using WavedocProyecto.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WavedocProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterPage : MasterDetailPage
    {
        public MainMasterPage()
        {
            InitializeComponent();
            this.MenuPaginas = new ObservableCollection<MasterPageItem>();

            MasterPageItem item = new MasterPageItem();
            item.Titulo = "Login";
            item.PaginaHija = typeof(Login);
            item.Icono = "Images/user.svg";
            this.MenuPaginas.Add(item);
            
            //enlazamos nuestro ViewModel con la Vista
            this.lsvMenuPaginas.ItemsSource = this.MenuPaginas;
            
            Detail = new NavigationPage
               ((Page)(Activator.CreateInstance
               (typeof(Login))));

            //NECESITAMOS EL EVENTO DEL CONTROL LISTVEW
            this.lsvMenuPaginas.ItemSelected += LsvMenuPaginas_ItemSelected;
        }


        private void LsvMenuPaginas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            MasterPageItem item = (MasterPageItem)e.SelectedItem;
            //RECUPERAMOS LA PAGINA A MOSTRAR
            Type pagina = item.PaginaHija;
            
            Detail = new NavigationPage(
                (Page)Activator.CreateInstance(pagina));
            //para ocultar el menu principal
            IsPresented = false;
        }

        public ObservableCollection<MasterPageItem> MenuPaginas { get; set; }

    }
}