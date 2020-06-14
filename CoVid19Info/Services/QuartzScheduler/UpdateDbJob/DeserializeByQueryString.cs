using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CoVid19Info.Services.QuartzScheduler.UpdateDbJob
{
    public static class DeserializeByQueryString
    {
        public static IEnumerable<T> GetModels<T>(string queryString)
        {
            var json = GetJsonByQueryString(queryString);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static T GetModel<T>(string queryString)
        {
            var json = GetJsonByQueryString(queryString);

            return JsonConvert.DeserializeObject<T>(json);
        }

        private static string GetJsonByQueryString(string queryString)
        {
            var webRequest = WebRequest.Create(queryString);
            var streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream() ?? throw new ArgumentNullException());

            return streamReader.ReadToEnd();
        }
    }
}