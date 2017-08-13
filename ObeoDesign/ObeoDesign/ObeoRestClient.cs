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
        httpRequestType httpMethod;
     
       public ObeoRestClient(String u)
        {
            uri = u;
        }

        public string uriEndpoint { get { return uri; } set { uri = uriEndpoint; } }
        public httpRequestType requestMethod { get { return httpMethod; } set { httpMethod = requestMethod; } }

        public String executeRequest() {
            String strResponse = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error : It NAH Work " + response.StatusCode.ToString());
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null) {
                        using (StreamReader reader = new StreamReader(responseStream)) {
                            strResponse = reader.ReadToEnd();
                        }
                    }
                }
            }
                return strResponse;
        }

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
