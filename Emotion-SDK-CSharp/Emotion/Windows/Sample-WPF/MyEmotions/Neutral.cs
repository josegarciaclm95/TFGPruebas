using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Neutral:_Emotion
    {
        public Neutral(float score) : base("Neutral", score)
        {
        }

        public override string compare_emotions(_Emotion emotion)
        {
            return "Neutral and " + emotion.Name;
        }

        public override string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            string[] ems = { "Disgust", "Sadness"};
            if (ems.Any(l => l == emotion1.Name) || ems.Any(l => l == emotion2.Name))
            {
                return "Patient deteriorating. Soften activity";
            }
            else
            {
                return "Neutral, " + emotion1.Name + " and " + emotion2.Name;
            }
        }
    }
}
