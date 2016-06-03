using Affdex;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PruebaAffective
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        //, FaceListener, ImageListener, ProcessStatusListener
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        public void onFaceFound(float timestamp, int faceId)
        {
            throw new NotImplementedException();
        }

        public void onFaceLost(float timestamp, int faceId)
        {
            throw new NotImplementedException();
        }

        public void onImageCapture(Affdex.Frame frame)
        {
            throw new NotImplementedException();
        }

        public void onImageResults(Dictionary<int, Face> faces, Affdex.Frame frame)
        {
            throw new NotImplementedException();
        }

        public void onProcessingException(AffdexException ex)
        {
            throw new NotImplementedException();
        }

        public void onProcessingFinished()
        {
            throw new NotImplementedException();
        }
        */

        private void buscar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog image_search = new OpenFileDialog();
            image_search.ShowDialog();
            image_source.Text = image_search.FileName;
            choosen_picture.Source = new BitmapImage(new Uri(image_source.Text,UriKind.Absolute));
            
            PhotoDetector detector = new PhotoDetector();
           /* detector.setLicensePath("C:\\Users\\Usuario\\Dropbox\\TRABAJO FIN DE GRADO - INVESTIGACION\\Investigacion_Horizontal\\Affectiva\\sdk_garciagarciajosemaria@outlook.es.license");
            detector.setClassifierPath("C:\\Program Files\\Affectiva\\Affdex SDK\\data");
            detector.setFaceListener(this);
            detector.setImageListener(this);
            detector.setProcessStatusListener(this);
            detector.setDetectAllEmotions(true);
            detector.start();*/
        }
    }


}
