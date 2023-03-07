using System.Windows;
using System.Windows.Input;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isLoggedIn = false;
        public string LoggedInUsername { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            UpdateButtons();

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void btnMenuLogin_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserPage();
        }

        private void btnMenuSchowek_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new StoragePage();


        }

        private void btnMenuKalorie_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CalculatorCaloriesPage();
        }

        public void btnMenuBMI_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CalculatorBMIPage();
        }

        private void btnMenusearch_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new WebSearchPage();
        }
        public void UpdateButtons()
        {


            
            btnMenuSchowek.IsEnabled = isLoggedIn;
            btnMenusearch.IsEnabled = isLoggedIn;
            btnMenuKalorie.IsEnabled = isLoggedIn;
        }



        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
             MessageBox.Show("Hi it's me Creator of this app. If you have any questions about app or have some great ideas to improve it, please contact me xyz.xyz@gmail.com\n P.S. Try to click ladybird on Calendar ;)", "Have Question?", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}

