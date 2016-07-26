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
using System.Windows.Shapes;
using Microsoft.Expression.Encoder.Devices;
using WebcamControl;
using System.IO;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using System.Net.Http;

namespace EmotionAPI_WPF_Samples
{
    /// <summary>
    /// Lógica de interacción para Prototipo.xaml
    /// </summary>
    public partial class Prototipo : Window
    {
        string videoPath;
        string imagePath;
        string key = "45f9f87d2879492e8d53f659827f6e9e";

        public Prototipo()
        {
            InitializeComponent();
            
            Binding binding_1 = new Binding("SelectedValue");
            binding_1.Source = VideoDevicesComboBox;
            WebcamCtrl.SetBinding(Webcam.VideoDeviceProperty, binding_1);

            Binding binding_2 = new Binding("SelectedValue");
            binding_2.Source = AudioDevicesComboBox;
            WebcamCtrl.SetBinding(Webcam.AudioDeviceProperty, binding_2);

            // Create directory for saving video files
            videoPath = @"C:\Users\Usuario\Documents\Universidad\Investigación\pruebasTFG\Emotion-SDK-CSharp";

            if (!Directory.Exists(videoPath))
            {
                Directory.CreateDirectory(videoPath);
            }
            // Create directory for saving image files
            imagePath = @"C:\Users\Usuario\Documents\Universidad\Investigación\pruebasTFG\Emotion-SDK-CSharp";

            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }

            // Set some properties of the Webcam control
            WebcamCtrl.VideoDirectory = videoPath;
            WebcamCtrl.ImageDirectory = imagePath;
            WebcamCtrl.FrameRate = 30;
            WebcamCtrl.FrameSize = new System.Drawing.Size(640, 480);

            // Find available a/v devices
            var vidDevices = EncoderDevices.FindDevices(EncoderDeviceType.Video);
            var audDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            VideoDevicesComboBox.ItemsSource = vidDevices;
            AudioDevicesComboBox.ItemsSource = audDevices;
            VideoDevicesComboBox.SelectedIndex = 0;
            AudioDevicesComboBox.SelectedIndex = 0;
            
        }

        private void StartCaptureButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Display webcam video
                WebcamCtrl.StartPreview();
            }
            catch (Microsoft.Expression.Encoder.SystemErrorException ex)
            {
                MessageBox.Show("Device is in use by another application");
            }
        }

        private void StopCaptureButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop the display of webcam video.
            WebcamCtrl.StopPreview();
        }

        private void StartRecordingButton_Click(object sender, RoutedEventArgs e)
        {
            // Start recording of webcam video to harddisk.
            WebcamCtrl.StartRecording();
        }

        private void StopRecordingButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop recording of webcam video to harddisk.
            WebcamCtrl.StopRecording();
        }

        private void TakeSnapshotButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam video.
            WebcamCtrl.TakeSnapshot();
        }

        private async void AnalyseFeeling_Click(object sender, RoutedEventArgs e)
        {
            string image_url = "";
            clean_Directory();
            WebcamCtrl.TakeSnapshot();
            Emotion[] emotionResult = null;
            image_url = lookFor_Snap();
            emotionResult = await lookFor_Emotions(image_url);
            log_Emotions(emotionResult);
        }

        private async Task<Emotion[]> lookFor_Emotions(string image_url)
        {
            Emotion[] emotionResult = null;
            EmotionServiceClient emotionServiceClient = new EmotionServiceClient(key);
            using (Stream imageFileStream = File.OpenRead(image_url))
            {
                // Detect the emotions in the URL
                // Pasamos el flujo de bytes que es la imagen al servicio Recognize y nos devuelve una lista de emotionResults
                try
                {
                    emotionResult = await emotionServiceClient.RecognizeAsync(imageFileStream);
                    results.Text += "He devuelto algo :/\n";
                    return emotionResult;
                }
                catch (HttpRequestException)
                {
                    results.Text += "Ups...problemas con la red\n";
                }
                catch (IOException)
                {
                    results.Text += "No hay cara que analizar :/\n";
                }
            }
            return emotionResult;
        }

        private void log_Emotions(Emotion[] emotionResult)
        {
            results.Text += "He llegado aqui\n";
            if (emotionResult != null && emotionResult.Length >= 1)
            {
                foreach (var emoti in emotionResult)
                {
                    results.Text += "Happiness: " + emoti.Scores.Happiness.ToString() + "\n";
                    results.Text += "Fear: " + emoti.Scores.Fear.ToString() + "\n";
                    results.Text += "Surprise: " + emoti.Scores.Surprise.ToString() + "\n";
                    results.Text += "Contempt: " + emoti.Scores.Contempt.ToString() + "\n";
                    results.Text += "Sadness: " + emoti.Scores.Sadness.ToString() + "\n";
                    results.Text += "Neutral: " + emoti.Scores.Neutral.ToString() + "\n";
                    results.Text += "Disgust: " + emoti.Scores.Disgust.ToString() + "\n";
                    results.Text += "Anger: " + emoti.Scores.Anger.ToString() + "\n";
                }
            } else
            {
                results.Text += "Ups...vacio el result";
            }
        }

        private void clean_Directory()
        {
            DirectoryInfo di = new DirectoryInfo(imagePath);
            foreach (var file in di.GetFiles("Snap*"))
            {
                results.Text += file.Name + " borrado\n";
                file.Delete();
            }
        }

        private string lookFor_Snap()
        {
            DirectoryInfo di = new DirectoryInfo(imagePath);
            foreach (var file in di.GetFiles("Snap*"))
            {
                results.Text += file.Name + " detectada\n";
                results.Text += file.FullName + "\n";
                return file.FullName;
            }
            return "";
        }
    }
}
