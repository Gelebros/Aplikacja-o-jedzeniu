using System;
using System.Windows;
using System.Windows.Controls;

namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for Stronaschowel.xaml
    /// </summary>
    public partial class StoragePage : Page
    {
        public StoragePage()
        {
            InitializeComponent();
        }

        private void btntotalCal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("TotalCalories.xaml", UriKind.Relative));
        }

        private void btnChangesBMI_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("BMIChanges.xaml", UriKind.Relative));
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Calendar.xaml", UriKind.Relative));
        }

        private void btnFvLinks_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("FavLinks.xaml", UriKind.Relative));
        }
    }
}
