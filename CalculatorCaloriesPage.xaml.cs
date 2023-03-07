using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;









namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for Stronakalkulatorkalori.xaml
    /// </summary>
    public partial class CalculatorCaloriesPage : Page
    {
        private decimal totalCalories = 0;
        public CalculatorCaloriesPage()
        {
            InitializeComponent();
            LoadData();


        }





        public class Products
        {
            public string Meal { get; set; }
            public string Drinks { get; set; }
            public string Singleproducts { get; set; }
            public decimal Calories { get; set; }
        }

        private Products SelectedProduct;

        private void datagridCal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SelectedProduct = (Products)datagridCal.SelectedItem;
        }

        private void btnAddSPCal_Click(object sender, RoutedEventArgs e)
        {
            decimal calorieValue = SelectedProduct.Calories;
            totalCalories += calorieValue;
            lblCal.Content = totalCalories.ToString();


        }

        private void LoadData()
        {
            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            string query1 = "SELECT * FROM dbo.Drinks";
            string query2 = "SELECT * FROM dbo.FullMeals";
            string query3 = "SELECT * FROM dbo.SingleProducts";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            List<Products> products = new List<Products>();

            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products
                    {
                        Drinks = reader["Drinks"].ToString(),
                        Calories = decimal.Parse(reader["Calories"].ToString())
                    });
                }
            }

            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products
                    {
                        Meal = reader["Meal"].ToString(),
                        Calories = decimal.Parse(reader["Calories"].ToString())
                    });
                }
            }

            using (SqlCommand command = new SqlCommand(query3, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products
                    {
                        Singleproducts = reader["singleproducts"].ToString(),
                        Calories = decimal.Parse(reader["Calories"].ToString())
                    });
                }

            }

            datagridCal.ItemsSource = products;
        }

        private void btnResetCal_Click(object sender, RoutedEventArgs e)
        {
            totalCalories = 0;
            lblCal.Content = totalCalories.ToString();
        }

        private void btnSaveCalories_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                string username = mainWindow.LoggedInUsername;
                string tableName = "[" + username + "CaloriesData]";
                string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            
                string insertOrUpdateQuery = "IF NOT EXISTS (SELECT * FROM " + tableName + " WHERE RecordDate = @RecordDate) " +
                                                "BEGIN " +
                                                "    INSERT INTO " + tableName + " (RecordDate, Calories) VALUES (@RecordDate, @Calories); " +
                                                "END " +
                                                "ELSE " +
                                                "BEGIN " +
                                                "    UPDATE " + tableName + " SET Calories = @Calories WHERE RecordDate = @RecordDate;" +
                                                "END;";
                using (SqlCommand insertOrUpdateCommand = new SqlCommand(insertOrUpdateQuery, connection))
                {
                    insertOrUpdateCommand.Parameters.AddWithValue("@RecordDate", DateTime.Today);
                    insertOrUpdateCommand.Parameters.AddWithValue("@Calories", Convert.ToDecimal(lblCal.Content));
                    insertOrUpdateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Calories saved successfully");
            }
            catch (SqlException )
            {
                MessageBox.Show("An error occurred while saving the data, please create the table: " );
            }


        }


        private void btnResetData_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "CaloriesData]";
            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using (SqlCommand command = new SqlCommand("UPDATE " + tableName + " SET Calories = 0 WHERE RecordDate = @RecordDate", connection))
            {
                command.Parameters.AddWithValue("@RecordDate", DateTime.Today);
                command.ExecuteNonQuery();

            }
            MessageBox.Show("Calories for today have been removed");


        }

        private void btnCreateTableCal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "CaloriesData]";

            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = @tableName) " +
                           "BEGIN " +
                           "CREATE TABLE " + tableName + " ([RecordDate] DATE NULL, [Calories] DECIMAL(18, 0) NULL); " +
                           "SELECT 'Table created' AS Message; " +
                           "END " +
                           "ELSE " +
                           "BEGIN " +
                           "SELECT 'Table already exists' AS Message; " +
                           "END";
            using SqlCommand command = new SqlCommand(query, connection);
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}






