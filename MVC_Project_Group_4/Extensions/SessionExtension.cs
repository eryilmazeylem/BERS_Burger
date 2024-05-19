using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace MVC_Project_Group_4.Extensions
{
    //public static class SessionExtension
    //{
    //    // Oturum verisini JSON olarak ayarlamak için uzantı yöntemi
    //    public static void SetObjectAsJson(this ISession session, string key, object value)
    //    {
    //        session.SetString(key, JsonConvert.SerializeObject(value));
    //    }

    //    // Oturum verisini JSON olarak almak için uzantı yöntemi
    //    public static T? GetObjectFromJson<T>(this ISession session, string key)
    //    {
    //        var value = session.GetString(key);
    //        return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
    //    }
    //}
}
