using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    abstract class _Emotion
    {
        private string name;
        private float score;

        public _Emotion(string name, float score)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return name + ", Score =  " + score;
        }

        public virtual string compare_emotions(_Emotion emotion)
        {
            return "A mix of " + this.Name + " and " + emotion.Name;
        }

        public virtual string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            return "A mix of " + this.Name + " and " + emotion1.Name + " and " + emotion2.Name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

    }
}
