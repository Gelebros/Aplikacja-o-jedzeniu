using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for TotalCalories.xaml
    /// </summary>
    public partial class TotalCalories : Page
    {
        public TotalCalories()
        {
            InitializeComponent();
            LoadData();
            lblTotalCal.Content = "Your energy needs are based on how many calories you need to consume per day to meet your needs and stay healthy.\n " +
                "They can be calculated on the basis of the 24-hour metabolism.\n\n" +
                      "60 to 70 percent daily requirements are consumed by your internal organs as a result of metabolic \n" +
                      " processes necessary to maintain the body's work;\n" +
                      "from 20 to 40 percent energy is used during very different forms of physical effort;\n" +
                      "10 percent energy is needed to maintain the correct body temperature and is stored.";
        }

        public class CaloriesData
        {
            public DateTime RecordDate { get; set; }
            public decimal Calories { get; set; }
        }
        private void LoadData()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string username = mainWindow.LoggedInUsername;
            string tableName = "[" + username + "CaloriesData]";

            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    ObservableCollection<CaloriesData> caloriesList = new ObservableCollection<CaloriesData>();
                    string query = "SELECT * FROM " + tableName;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            caloriesList.Add(new CaloriesData
                            {
                                RecordDate = DateTime.Parse(reader["RecordDate"].ToString()),
                                Calories = decimal.Parse(reader["Calories"].ToString())
                            });
                        }
                    }

                    datagridTotalCal.ItemsSource = caloriesList;
                }
                catch (SqlException )
                {
                    MessageBox.Show("Please create table in CalorieCalcualtor window " ,"Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void datagridTotalCal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


   
}
