using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4.Helpers.Serialization;

namespace Lab_4.Helpers.Serialization
{
    public class SerializerManager
    {
        private static Dictionary<string, ISerializer> serializersDict = new Dictionary<string, ISerializer>
        {
            { "json", new JSONSerializer() }
        };

        public static List<string> availableFormats = new List<string>
        {
            "json"
        };

        public static void LoadFormat()
        {
            //TODO
        }

        public static ISerializer GetSerializer(string key)
        {
            return serializersDict[key];
        }
    }
}
