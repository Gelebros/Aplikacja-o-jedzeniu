using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for stronaużytkownik.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        

        private void btncreateaccount_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RegistrationPage.xaml", UriKind.Relative));
        }
        
        private void btnaccept_Click(object sender, RoutedEventArgs e)
        {
            
            string username = txtusserbox.Text;
            string password = txtpasswordbox.Password;

            
            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            using SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            int result = (int)command.ExecuteScalar();

            if (result > 0)
            {

                lblLoginStatus.Content = "User logged in successfully!";
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.isLoggedIn = true;

                
                mainWindow.btnMenuSchowek.IsEnabled = true;
                mainWindow.btnMenuKalorie.IsEnabled = true;
                mainWindow.btnMenusearch.IsEnabled = true;
                mainWindow.LoggedInUsername = username;


            }
            else
            {

                lblLoginStatus.Content = "Invalid username or password, if not try to register!";

            }
        }
    }
    }

