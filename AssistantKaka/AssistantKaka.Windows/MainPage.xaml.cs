using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AssistantKaka
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Random rand = new Random();
        public MainPage()
        {
            this.InitializeComponent();
            KakaVoice.Volume = 1;   //1 for loudest and 0 for mute
        }

        private void txtInput_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (txtInput.Text == "Enter your query to interact with kaka")
            {
                txtInput.Text = string.Empty;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtInput.Text == "Enter your query to interact with kaka")
                {
                    if (rand.Next() % 2 == 0)
                    {
                        lblKakaStatus.Text = "Bagha hai....";
                        KakaVoice.Source = new Uri("ms-appx:///Assets/Audio/Bagha.mp3", UriKind.RelativeOrAbsolute);    
                    }
                    else
                    {
                        lblKakaStatus.Text = "Kone behadiyo aahi....";
                        KakaVoice.Source = new Uri("ms-appx:///Assets/Audio/Kone_Behadiyo.mp3", UriKind.RelativeOrAbsolute);    
                    }
                    KakaVoice.Play();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                //MessageDialog msg = new MessageDialog("Plase Select any media file");
                //msg.ShowAsync();
            }
        }
    }
}
