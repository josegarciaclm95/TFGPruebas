using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;

namespace EmotionAPI_WPF_Samples
{
    class EmotionAnalysis
    {
        Emotion[] results = null;
        
        public EmotionAnalysis(Emotion[] emotions)
        {
            emotions.CopyTo(results, 0);
        }
        public List<Tuple<string,int>> check_emotions()
        {
            return null;
        }
    }
}
