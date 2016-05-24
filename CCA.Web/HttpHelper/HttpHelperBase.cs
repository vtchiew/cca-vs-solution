using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CCA.Web.HttpHelper
{

    public class HttpHelperBase
    {
        public static string _SERVER = System.Configuration.ConfigurationManager.AppSettings["ServerAPIPath"];

        async public static Task<T> ApiCallPostAsync<T>(string path, object para) where T : CCA.Common.Models.ReturnData.ReturnDataBase, new()
        {
            try
            {
                using (HttpClient hc = new HttpClient())
                {
                    var request = new HttpRequestMessage()
                    {
                        RequestUri = new Uri(System.IO.Path.Combine(_SERVER, path)),
                        Method = HttpMethod.Post,
                        Content = new StringContent(JsonConvert.SerializeObject(para))
                    };
                    request.Headers.AcceptLanguage.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue(Thread.CurrentThread.CurrentCulture.Name));

                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    //var result = await hc.PostAsync(System.IO.Path.Combine(_SERVER, path), new StringContent(JsonConvert.SerializeObject(para)));
                    var result = await hc.SendAsync(request);
                    var str = await result.Content.ReadAsStringAsync();
                    T ret = JsonConvert.DeserializeObject<T>(str);
                    return ret;
                }
            }
            catch(Exception ex)
            {
                T err = new T();
                err.SetError(ex);
                return err;
            }
        }
    }
}