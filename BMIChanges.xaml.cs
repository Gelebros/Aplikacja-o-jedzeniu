using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for BMIChanges.xaml
    /// </summary>
    public partial class BMIChanges : Page
    {
        public BMIChanges()
        {
            InitializeComponent();
            LoadData();
            Paragraph para = new Paragraph();
            para.Inlines.Add(new Run("BMI categories:\n"));
            para.Inlines.Add(new Run("Underweight") { Foreground = Brushes.White });
            para.Inlines.Add(new Run(" = <18.5\n"));
            para.Inlines.Add(new Run("Normal weight") { Foreground = Brushes.Green });
            para.Inlines.Add(new Run(" = 18.5-24.9\n"));
            para.Inlines.Add(new Run("Overweight") { Foreground = Brushes.Yellow });
            para.Inlines.Add(new Run(" = 25-29.9\n"));
            para.Inlines.Add(new Run("Obesity") { Foreground = Brushes.Red });
            para.Inlines.Add(new Run(" = BMI of 30 or greater"));
            rtxBMIChang.Document.Blocks.Add(para);
            rtxBMIChang.IsReadOnly = true;
        }

        public class ChangesforBMI
        {
            public string Username { get; set; }
            public float Weight { get; set; }
            public float Height { get; set; }
            public string Gender { get; set; }
            public decimal Bmi { get; set; }
        }

        private void LoadData()
        {

            string connectionString = "\\SQLEXPRESS;Initial Catalog=BazaUżytkownik;Integrated Security=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            ObservableCollection<ChangesforBMI> bmilist = new ObservableCollection<ChangesforBMI>();
            string query = "SELECT * FROM BMIData";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bmilist.Add(new ChangesforBMI
                    {
                        Username = reader["Username"].ToString(),
                        Weight = float.Parse(reader["Weight"].ToString()),
                        Height = float.Parse(reader["Height"].ToString()),
                        Gender = reader["Gender"].ToString(),
                        Bmi = decimal.Parse(reader["Bmi"].ToString()),

                    });
                }
            }

            datagridBMI.ItemsSource = bmilist;
        }
        /* Underweight = <18.5
             * Normal weight = 18.5-24.9
             * Overweight = 25-29.9
             * Obesity = BMI of 30 or greater */


        private void datagridBMI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rtxBMIChang_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
