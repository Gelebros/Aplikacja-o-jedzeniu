using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace Frontend_aplikacja_o_jedzeniu
{
    /// <summary>
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class Calendar : Page
    {
        public Calendar()
        {
            InitializeComponent();
            QuoteRandom quote = new QuoteRandom () { Randomizer = new Random() };
            lblrandomquote.Content = quote.GetQuoteRandom();
        }

        public class QuoteRandom
        {
            public Random Randomizer;

            string[] MotivationText = { "“We cannot solve problems with the kind of thinking we employed when we came up with them.” — Albert Einstein",
                "“Learn as if you will live forever, live like you will die tomorrow.” — Mahatma Gandhi",
                "“Stay away from those people who try to disparage your ambitions. Small minds will always do that,\n but great minds will give you a feeling that you can become great too.” — Mark Twain",
                 "“When you give joy to other people, you get more joy in return.\n You should give a good thought to happiness that you can give out.”— Eleanor Roosevelt",
                "“When you change your thoughts, remember to also change your world.”—Norman Vincent Peale",
                 "“It is only when we take chances, when our lives improve. The initial\n and the most difficult risk that we need to take is to become honest. —Walter Anderson",
                  "“Nature has given us all the pieces required to achieve exceptional wellness and health,\n but has left it to us to put these pieces together.”—Diane McLaren",
                "“Success is not final; failure is not fatal: It is the courage to continue that counts.” — Winston S. Churchill",
                "“It is better to fail in originality than to succeed in imitation.” — Herman Melville",
                "“The road to success and the road to failure are almost exactly the same.” — Colin R. Davis",
                "“Success usually comes to those who are too busy looking for it.” — Henry David Thoreau",
                "“Develop success from failures. Discouragement and failure are two\n of the surest stepping stones to success.” —Dale Carnegie",
                "“There are three ways to ultimate success: The first way is to be kind.\n The second way is to be kind. The third way is to be kind.” —Mister Rogers"
            };
            public string GetQuoteRandom()
            {
                string randomMotivationTexts = MotivationText[Randomizer.Next(MotivationText.Length)];
                return randomMotivationTexts;
            }






        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _ = NavigationService.Navigate(new Uri("EasterEgg.xaml", UriKind.Relative));
        }



        private void ImageStork_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            BitmapImage newImage = new BitmapImage(new Uri("icons8_flying_stork_with_bundle_96px.png", UriKind.Relative));
            ImageStork.Source = newImage;
        }


    }
}
