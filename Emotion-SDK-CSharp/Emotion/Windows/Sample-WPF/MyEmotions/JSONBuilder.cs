using System;
using Newtonsoft.Json.Linq;

namespace EmotionAPI_WPF_Samples
{
    internal class JSONBuilder
    {
        private JObject intern_json;
        private JArray analysis;
        private JObject actual_analysis;

        public JSONBuilder()
        {
            intern_json = new JObject();
            analysis = new JArray();
        }

        public string InternJSON
        {
            get
            {
                return intern_json.ToString();
            }
        }

        internal void initializeSesion()
        {
            intern_json["date_session"] = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss");
        }

        internal void initializeAnalysis()
        {
            actual_analysis = new JObject();
            actual_analysis["analysis_start_time"] = DateTime.Now.ToString("H:mm:ss");
        }

        internal void analysisResults(string v)
        {
            actual_analysis["analysis_result"] = v;
            analysis.Add(actual_analysis);
            //actual_analysis = new JObject();
        }

        internal void FinishAnalysis()
        {
            intern_json["results"] = analysis;
            System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\emotion_analysis_" + DateTime.Now.ToString("dd-MM-yyyy_H_mm_ss") + ".json", intern_json.ToString());
        }
    }
}