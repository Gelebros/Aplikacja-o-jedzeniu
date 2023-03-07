using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;


namespace Frontend_aplikacja_o_jedzeniu
{

    /// <summary>
    /// Interaction logic for FavLinks.xaml
    /// </summary>
    public partial class FavLinks : Page
    {


        public FavLinks()
        {
            InitializeComponent();
            LoadData();


        }
        private void DeleteSelectedLink()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "FavoriteLinks]";

            string selectedLink = ListVFavLinks.SelectedItem?.ToString();
            if (selectedLink != null)
            {
                try
                {
                    string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
                    using SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string query = "DELETE FROM " + tableName + " WHERE Links=@selectedLink;";
                    using SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedLink", selectedLink);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        LoadData();
                    }
                }
                catch (SqlException)
                {
                     MessageBox.Show("An error occurred while deleting the link. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LoadData()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "FavoriteLinks]";

            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT Links FROM " + tableName + ";";
            using SqlCommand command = new SqlCommand(query, connection);
            List<string> linksList = new List<string>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                linksList.Add(reader["Links"].ToString());
            }
            ListVFavLinks.ItemsSource = linksList;


        }

        private void ListVFavLinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void BtnDeleteSelLink_Click(object sender, RoutedEventArgs e)
        {
            DeleteSelectedLink();
        }

        private void BtnSelectLinkToBrowser_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
