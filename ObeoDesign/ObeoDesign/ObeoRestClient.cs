using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace ObeoDesign
{
    public enum httpRequestType
    {
        GET,
        POST
    }
    class ObeoRestClient
    {
        String uri;
     
       public ObeoRestClient(String u)
        {
            uri = u;
        }

        public string uriEndpoint { get { return uri; } set { uri = uriEndpoint; } }
    

        public async Task<string> GetRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
        }

        public async void PostRequest(Route r)
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("journey_origin",r.Origin),
                new KeyValuePair<string, string>("journey_destination",r.Destination),
                new KeyValuePair<string, string>("journey_distance",r.Distance),
                new KeyValuePair<string, string>("journey_duration",r.Duration),
                new KeyValuePair<string, string>("journey_mode",r.Mode),
            };
            HttpContent hC = new FormUrlEncodedContent(queries);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(uri,hC))
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();
                     
                      //  return result;
                    }
                }
            }
        }



    }
}
