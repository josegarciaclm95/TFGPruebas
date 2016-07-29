using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    abstract class _Emotion
    {
        public string name;
        public double score;

        public _Emotion(string name, double score)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return name + ", Score =  " + score;
        }

        public abstract string compare_emotions(_Emotion emotion);

        public abstract string compare_emotions(_Emotion emotion1, _Emotion emotion2);

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

        public double Score
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
