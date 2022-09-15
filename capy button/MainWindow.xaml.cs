using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace capy_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            using (FileStream stream = File.Open(@"data\capybara ok i pull up.wav", FileMode.Open))
            {
                SoundPlayer myNewSound = new SoundPlayer(stream);
                myNewSound.Load();
                if (stream.CanSeek) stream.Seek(0, System.IO.SeekOrigin.Begin);
                myNewSound.Play();
                for (int i = 0; i < 8; i++)
                {
                    capy.Source = new BitmapImage(new Uri(@"data\capy flip.jpg", UriKind.RelativeOrAbsolute));
                    await Task.Delay(rnd.Next(300, 1300));
                    capy.Source = new BitmapImage(new Uri(@"data\capy plush.jpg", UriKind.RelativeOrAbsolute));
                    await Task.Delay(rnd.Next(300, 1300));
                }
                Close();
            }
        }
    }
}
