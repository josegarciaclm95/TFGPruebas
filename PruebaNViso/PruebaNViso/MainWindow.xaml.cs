using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
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

namespace PruebaNViso
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ruta = "";
        BitmapImage to_scan_photo = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog image_search = new OpenFileDialog();
            image_search.ShowDialog();
            ruta = image_search.FileName;
            textBox.Text = ruta;
            to_scan_photo = new BitmapImage(new Uri(textBox.Text, UriKind.Absolute));
            image_choosen.Source = to_scan_photo;
        }

        private void send_request_Click(object sender, RoutedEventArgs e)
        {
            HttpWebRequest request = WebRequest.Create(new Uri("http://3dfi.nviso.net/api/v1/process/emotion/image/upload/")) as HttpWebRequest;
            request.Headers["app_id"] = "3dedb029";
            request.Headers["app_key"] = "8225b0d6a06112699941df385e28562f";
            request.Headers["image"] = imageToBytes(to_scan_photo).ToString();
            request.Headers["consent"] = "1";
            request.Method = "POST";
            //request.ContentType = "application/x-www-form-urlencoded";
            var result = "";
            try
            {
                using (HttpWebResponse resp = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                textBox.Text = textBox.Text + "\n" + result;
            } catch(WebException v)
            {
                textBox.Text = textBox.Text + "\n" + "STAAAAAAPH";
                textBox.Text = textBox.Text + "\n" + v.ToString();
            }

            
        }

        public byte[] imageToBytes(BitmapImage image)
        {
            byte[] result = null;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                result = ms.ToArray();
            }
            return result;
        }
    }
}
