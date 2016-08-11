using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Disgust:_Emotion
    {
        public Disgust(float score) : base("Disgust", score)
        {
        }

        public override string compare_emotions(_Emotion emotion)
        {
            if (emotion.Name == "Sadness")
            {
                return "Pain. Abort activity";
            }
            else
            {
                return "Disgust and " + emotion.Name;
            }
        }
        public override string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            string[] ems = { "Contempt", "Sadness" };
            if (ems.Any(l => l == emotion1.Name) || ems.Any(l => l == emotion2.Name))
            {
                return "Pain. Abort activity";
            }
            else
            {
                return "Disgust, " + emotion1.Name + " and " + emotion2.Name;
            }
        }
    }
}
