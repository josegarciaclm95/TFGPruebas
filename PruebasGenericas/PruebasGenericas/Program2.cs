using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PruebasGenericas
{
    class Program2
    {
        static void Main(string[] args)
        {
            pruebaBuildJson();
            pruebaAny();
        }

        public static void pruebaAny()
        {
            string[] em = { "Anger", "Fear" };
            if (em.Any(l => l == "Anger"))
            {
                Console.WriteLine("Hay ira o miedo");
            }
            Console.ReadLine();
        }
        /*
         Working!!
             */
        public static void pruebaStringToJson()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\Usuario\Documents\Universidad\Investigación\pruebasTFG\PruebasGenericas\PruebasGenericas\rectangulo2HabHexaAnti.json");
            dynamic stuff = JObject.Parse(json);
            Console.WriteLine(stuff.forma + "\n" + stuff.puertas[0][0]);
            Console.ReadLine();
        }

        public static void pruebaBuildJson()
        {
            JObject session_results = new JObject();
            session_results["date-time"] = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss");
            JObject emotions_results = new JObject();
            emotions_results["final_result"] = "Pain";
            session_results["final"] = emotions_results;
            JObject aux = new JObject();
            aux["new"] = "Hola mundo";
            JObject results = session_results["final"] as JObject;
            results.Add(new JProperty("new_result","Happiness"));
            //results.Add(aux);
            JArray b = new JArray();
            JObject c = new JObject();
            c.Add(new JProperty("Hola","mundo"));
            b.Add(c);
            session_results.Add(new JProperty("Array",b));
            Console.WriteLine(session_results.ToString() + "\n" + System.IO.Directory.GetCurrentDirectory());
            string destiny = System.IO.Directory.GetCurrentDirectory() + "\\emotion_analysis_" + DateTime.Now.ToString("dd-MM-yyyy_H_mm_ss") + ".json";
            Console.WriteLine(destiny);
            System.IO.File.WriteAllText(destiny, session_results.ToString());

            Console.ReadLine();  
        }
    }
}

/*
 *
    A JToken is a generic representation of a JSON value of any kind. It could be a string, object, array, property, etc.
    A JProperty is a single JToken value paired with a name. It can only be added to a JObject, and its value cannot be another JProperty.
    A JObject is a collection of JProperties. It cannot hold any other kind of JToken directly.

 *
 */
