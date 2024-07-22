using Mauiverter.MVVM.ViewModel;
using Mauiverter.MVVM.Views;

namespace Mauiverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuView();
        }
    }
}
