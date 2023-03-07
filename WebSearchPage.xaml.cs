using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Data.SqlClient;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for wyszukiwarka.xaml
    /// </summary>
    public partial class WebSearchPage : Page
    {
        
        public WebSearchPage()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebBrowserSimple.Navigate(TxtBoxBrowser.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check if addres is correct", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void WebBrowserSimple_Navigated(object sender, NavigationEventArgs e)
        {
            
            TxtBoxBrowser.Text = WebBrowserSimple.Source.ToString();
              
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebBrowserSimple.GoForward();
            }
            catch (Exception )
            {
                MessageBox.Show("Somethink went wrong" , "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                WebBrowserSimple.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("Somethink went wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                WebBrowserSimple.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Somethink went wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        

        private void BtnSaveURL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                string username = mainWindow.LoggedInUsername;
                string tableName = "[" + username + "FavoriteLinks]";

                string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                string insertQuery = "INSERT INTO " + tableName + " (Links) VALUES (@Links)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Links", TxtBoxBrowser.Text);
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Link saved successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while saving the data, please create the table: " + ex.Message);
            }


        }

        private void BtnCreateTableWeb_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "FavoriteLinks]";

            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = @tableName) " +
                               "BEGIN " +
                               "CREATE TABLE " + tableName + " ([Links] VARCHAR(500) NULL); " +
                               "SELECT 'Table created' AS Message; " +
                               "END " +
                               "ELSE " +
                               "BEGIN " +
                               "SELECT 'Table already exists' AS Message; " +
                               "END";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["Message"].ToString());
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void TxtBoxBrowser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
