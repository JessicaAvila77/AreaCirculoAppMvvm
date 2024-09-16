using AreaCirculoAppMvvm.Views;

namespace AreaCirculoAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Borrar appxaml y mainpafe xaml, asignar la vista principal

            MainPage = new NavigationPage(new AreaCirculoView());
        }
    }
}
