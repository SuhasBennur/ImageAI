using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
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
using Microsoft.Win32;
using Newtonsoft.Json;
using static ImageAI.classes.Tags;

namespace ImageAI
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

        private void OnSelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofda = new OpenFileDialog();
            ofda.Filter = "Image Files (*.png; *jpg; *jpeg) | *.png; *.jpg; *.jpeg|All Files (*.*)|*.*";
            ofda.InitialDirectory =Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofda.ShowDialog() == true)
            {
                string filename=ofda.FileName;
                SeletedImage.Source = new BitmapImage(new Uri(filename));
                //MakePredicationAsync(filename);
            }

        }

        private async void MakePredicationAsync(string filename)
        {
            //string url = "";
            //string predication_key = "";
            //string content_type = "";
            //var file = File.ReadAllBytes(filename);

            //using (HttpClient client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Add("PredicatioL_key", predication_key);
            //    using (var content = new ByteArrayContent(file))
            //    {
            //        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(content_type);
            //        var response = await client.PostAsync(url, content);

            //        var responseString = await response.Content.ReadAsStringAsync();

            //        List<Prediction> predictions = (JsonConvert.DeserializeObject<CustomVision>(responseString)).Predictions;
            //        PredictionsListView.ItemsSource = predictions;
            //    }
            //}
        }
    }
}
