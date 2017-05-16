using Newtonsoft.Json;
using Lab_4.Books;

namespace Lab_4.Helpers.Serialization
{
    public class Serializer
    {
        public static string Serialize(Book smth)
        {
            return JsonConvert.SerializeObject(smth);
        }

        public static T Deserialize<T>(string smth)
        {
            return JsonConvert.DeserializeObject<T>(smth);
        }
    }
}