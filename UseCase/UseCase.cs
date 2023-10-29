using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase
{
    public class UseCase
    {
            

            [JsonProperty("Affect")]
            public string Affect { get; set; }
            public string AreaOfAffect { get; set; }
            public string Actor { get; set; }
            public string Precondition { get; set; }
            public string GuaranteesOfSuccess { get; set; }
            public string Trigger { get; set; }
            public string Description { get; set; }

            public static List<UseCase> list = new List<UseCase>();

            public static void LoadJson(string file)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                     string json = reader.ReadToEnd();
                     list = JsonConvert.DeserializeObject<List<UseCase>>(json);
                };
            }
    }
}
