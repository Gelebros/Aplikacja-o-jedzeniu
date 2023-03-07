using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;






namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for stronarejestracji.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnregaccept_Click(object sender, RoutedEventArgs e)
        {

            string username = txtregistername.Text;
            string password = txtregpasswordbox.Password;


            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        lblregistration.Content = "User already exists!";
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }


            lblregistration.Content = "User created successfully!";

        }
    }
}
