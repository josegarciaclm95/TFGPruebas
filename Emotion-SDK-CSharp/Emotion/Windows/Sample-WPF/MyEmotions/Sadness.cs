using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Sadness : _Emotion
    {
        public Sadness(float score) : base("Sadness", score)
        {
        }

        public new string compare_emotions(_Emotion emotion)
        {
            string[] ems = { "Disgust", "Neutral", "Anger" };
            if (ems.Any(l => l == emotion.Name))
            {
                return "Pain. Abort activity";
            }
            else
            {
                return "Sadness";
            }
        }

        public new string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            string[] ems = { "Disgust", "Anger" };
            if (ems.Any(l => l == emotion1.Name) || ems.Any(l => l == emotion2.Name))
            {
                return "Probably pain, careful";
            }
            else
            {
                return "Sadness, " + emotion1.Name + " and " + emotion2.Name;
            }
        }
        
    }
}
