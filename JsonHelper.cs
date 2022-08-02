using Newtonsoft.Json;
using System.IO;

namespace Helper
{
    public class JsonSerialization
    {
        public static void SerializeUser(User user)
        {
            var serializer = new JsonSerializer();

            string jSonFile = user.Name + ".json";
            using (var sw = new StreamWriter(jSonFile))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }

    
    }
}
