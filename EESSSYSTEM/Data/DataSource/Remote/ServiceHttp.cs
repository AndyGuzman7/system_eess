using EESSSYSTEM.Core.constanst;
using EESSSYSTEM.Data.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EESSSYSTEM.Data.DataSource.Remote
{
    public class ServiceHttp
    {
        public static async Task<JObject?> Get(Uri uri)
        {
            HttpClient client = new();
            try
            {

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);

                request.Headers.Add("Authorization", Credentials.BearerToken);
                request.Headers.Add("Notion-Version", Credentials.NotionVersion);

                HttpResponseMessage response = await client.SendAsync(request);

                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic json = JObject.Parse(responseBody);

                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public static async Task<JObject?> Get(Uri uri, HttpContent body)
        {
            HttpClient client = new();
            try
            {

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);

                request.Headers.Add("Authorization", Credentials.BearerToken);
                request.Headers.Add("Notion-Version", Credentials.NotionVersion);
                request.Content = body;
                HttpResponseMessage response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic json = JObject.Parse(responseBody);

                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
