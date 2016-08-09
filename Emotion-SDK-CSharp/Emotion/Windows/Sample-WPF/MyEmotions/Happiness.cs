using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Happiness : _Emotion
    {
        public Happiness(float score):base("Happiness",score)
        {
        }

        public new string compare_emotions(_Emotion emotion)
        {
            string[] ems = { "Anger" };
            if (ems.Any(l => l == emotion.Name))
            {
                return "Not real happiness. Probably pain, careful";
            }
            else
            {
                return "Happiness";
            }
        }

        public new string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            string[] ems = { "Sadness", "Anger" };
            if (ems.Any(l => l == emotion1.Name) || ems.Any(l => l == emotion2.Name))
            {
                return "Not real happiness. Probably pain, careful";
            }
            else
            {
                return "Happiness, " + emotion1.Name + " and " + emotion2.Name;
            }
        }
    }
}
