using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for StronakalkulatorBMI.xaml
    /// </summary>
    public partial class CalculatorBMIPage : Page
    {
        public CalculatorBMIPage()
        {
            InitializeComponent();
        }

        private void btncalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            double weight, height;

            if (!double.TryParse(txtweightbox.Text, out weight))
            {
                lblresultBMI.Content = "Weight can be only nubmer!";
                return;
            }
            if (!double.TryParse(txtheightbox.Text, out height))
            {
                lblresultBMI.Content = "Height can be only number!";
                return;
            }

            height /= 100;
            double bmi = weight / (height * height);
            bool isMale = (bool)RbtnMale.IsChecked;
            bool isFemale = (bool)RbtnFemale.IsChecked;

            if (isMale)
            {
                lblresultBMI.Content = "Mr BMI is: " + bmi.ToString();
            }
            else if (isFemale)
            {
                lblresultBMI.Content = "Mrs BMI is: " + bmi.ToString();
            }
            else
            {
                lblresultBMI.Content = "Please choose gender";
            }
        }

        private void btnSaveBMI_Click(object sender, RoutedEventArgs e)
        {
            {
                double weight, height, bmi;
                bool isMale, isFemale;
                string gender;

                if (!double.TryParse(txtweightbox.Text, out weight))
                {
                    lblresultBMI.Content = "Weight can be only nubmer!";
                    return;
                }
                if (!double.TryParse(txtheightbox.Text, out height))
                {
                    lblresultBMI.Content = "Height can be only number!";
                    return;
                }
               
                height /= 100;
                bmi = weight / (height * height);
                isMale = (bool)RbtnMale.IsChecked;
                isFemale = (bool)RbtnFemale.IsChecked;

                if (isMale)
                {
                    gender = "Male";
                }
                else if (isFemale)
                {
                    gender = "Female";
                }
                else
                {
                    lblresultBMI.Content = "Please choose gender";
                    return;
                }

                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                string username = mainWindow.LoggedInUsername;
                if (!mainWindow.isLoggedIn)
                {
                    lblresultBMI.Content = "You need to be logged in to save your BMI.";
                    return;
                }


                string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                using (SqlCommand command = new SqlCommand("IF EXISTS (SELECT * FROM BMIData WHERE Username = @Username) " +
                                               "BEGIN " +
                                               "UPDATE BMIData " +
                                               "SET Weight = @Weight, Height = @Height, Gender = @Gender, BMI = @BMI " +
                                               "WHERE Username = @Username " +
                                               "END " +
                                               "ELSE " +
                                               "BEGIN " +
                                               "INSERT INTO BMIData (Username, Weight, Height, Gender, BMI) " +
                                               "VALUES (@Username, @Weight, @Height, @Gender, @BMI) " +
                                               "END", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@Height", height);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@BMI", bmi);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblresultBMI.Content = "BMI has been saved";
                    }
                    else
                    {
                        lblresultBMI.Content = "BMI has not been saved";


                    }
                }

            }

        }
    }
}







