using System.Windows;
using System.Windows.Controls;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for EasterEgg.xaml
    /// </summary>
    public partial class EasterEgg : Page
    {
        public EasterEgg()
        {
            InitializeComponent();
        }

        private void BtnCalSleep_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtHoursBox.Text, out int hours) && int.TryParse(TxtMinBox.Text, out int minutes) &&
             hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
            {
                int totalMinutes = hours * 60 + minutes;
                int cycleMinutes = 90;
                int cycles = totalMinutes / cycleMinutes;
                _ = totalMinutes % cycleMinutes;

                lblSleep.Content = $"You should try to wake up at one of the following times:\n\n";
                for (int i = 1; i <= 6; i++)
                {
                    int wakeUpMinutes = (cycles + i) * cycleMinutes;
                    int wakeUpHours = wakeUpMinutes / 60;
                    wakeUpHours %= 24; 
                    int wakeUpRemMinutes = wakeUpMinutes % 60;

                    lblSleep.Content += $"{wakeUpHours:D2}:{wakeUpRemMinutes:D2}\n";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid time in the format HH:mm.", "Incorrect data", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnResetSleep_Click(object sender, RoutedEventArgs e)
        {
            TxtHoursBox.Text = "";
            TxtMinBox.Text = "";
            lblSleep.Content = "";
        }
    }
}
