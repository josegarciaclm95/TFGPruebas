using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Anger:_Emotion
    {
        public Anger(float score) : base("Anger", score)
        {
        }

        public override string compare_emotions(_Emotion emotion)
        {
            string[] ems = { "Disgust", "Sadness" };
            if (ems.Any(l => l == emotion.Name))
            {
                return "Pain. Abort activity";
            }
            else
            {
                return "Anger, " + emotion.Name;
            }
        }

        public override string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            string[] ems = {"Disgust","Sadness","Anger" };
            if (ems.Any(l => l == emotion1.Name) || ems.Any(l => l == emotion2.Name))
            {
                return "Pain. Abort activity";
            }
            else
            {
                return "Anger, " + emotion1.Name + " and " + emotion2.Name;
            }
        }
    }
}
