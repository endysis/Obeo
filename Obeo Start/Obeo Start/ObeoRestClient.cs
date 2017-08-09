using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace Obeo_Start
{
    public enum httpRequestType {
          GET,
          POST
    }

    class ObeoRestClient
    {
        String uri;
        httpRequestType httpMethod;

       public ObeoRestClient(String u, httpRequestType h)
        {
            uri = u;
            httpMethod = h;
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




    }
}
