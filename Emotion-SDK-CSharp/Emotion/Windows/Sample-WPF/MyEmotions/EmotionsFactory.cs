using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class EmotionsFactory
    {
        public _Emotion MakeEmotion(string name, float score)
        {
            _Emotion made_emotion = null;
            if (name.Equals("Anger"))
            {
                made_emotion = new Anger(score);
            }
            if (name.Equals("Contempt"))
            {
                made_emotion = new Contempt(score);
            }
            if (name.Equals("Disgust"))
            {
                made_emotion = new Disgust(score);
            }
            if (name.Equals("Fear"))
            {
                made_emotion = new Fear(score);
            }
            if (name.Equals("Happiness"))
            {
                made_emotion = new Happiness(score);
            }
            if (name.Equals("Neutral"))
            {
                made_emotion = new Neutral(score);
            }
            if (name.Equals("Sadness"))
            {
                made_emotion = new Sadness(score);
            }
            if (name.Equals("Surprise"))
            {
                made_emotion = new Surprise(score);
            }
            return made_emotion;
        }
    }
}
