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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PruebaKairos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //url.Text = System.IO.Path.GetTempFileName();
        }

        private void seekImage_Click(object sender, RoutedEventArgs e)
        {
            //url.Text = "https://api.kairos.com/media?source=http://josemariagarcia.es/certificados/dolor.mp4";
            HttpWebRequest request = WebRequest.Create(new Uri("https://api.kairos.com/media?"+"source="+url.Text)) as HttpWebRequest;
            url.Text = "https://api.kairos.com/media?" + "source=" + url.Text;
            request.Headers["app_id"] = "5e84c1f9";
            request.Headers["app_key"] = "7cb50dfd597bfbe4d7aca51c3d467f14";
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            var result = "";
            using ( HttpWebResponse resp = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
            answer.Text = " ";
            /* foreach(var a in result)
            {
                answer.Text = answer.Text + a;
            }
            */
            answer.Text = result;
            JToken token = JObject.Parse(result);
            string id = (string)token.SelectToken("id");
            answer.Text = answer.Text + id;
            File.WriteAllText(@"C:\Users\Usuario\Documents\Universidad\Investigación\pruebasTFG\PruebaKairos\PruebaKairos\result.txt", result);
            System.Threading.Thread.Sleep(10000);
            recibir(id);
        }
    
        private void recibir(string id)
        {
            string result = "";
            HttpWebRequest request = WebRequest.Create(new Uri("https://api.kairos.com/media/" + id)) as HttpWebRequest;
            answer.Text = "https://api.kairos.com/media/" + id;
            request.Headers["app_id"] = "5e84c1f9";
            request.Headers["app_key"] = "7cb50dfd597bfbe4d7aca51c3d467f14";
            request.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse) request.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());
            result = reader.ReadToEnd();
            result = JsonConvert.SerializeObject(result,Formatting.Indented);
            File.WriteAllText(@"C:\Users\Usuario\Documents\Universidad\Investigación\pruebasTFG\PruebaKairos\PruebaKairos\result2.json", result);
        }
    }
}

