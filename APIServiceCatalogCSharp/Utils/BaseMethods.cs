using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;

namespace APIServiceCatalogCSharp.Utils
{
   public static class BaseMethods
    {

        public static Dictionary<string, string> DeserializeResponse(this IRestResponse response)
        {
            var deserializeObj = new JsonDeserializer().Deserialize<Dictionary<string, string>>(response);
            return deserializeObj;
        }

        public static string GetResponseAsObjct(this IRestResponse response, string responseObjct)
        {
            JObject obj = JObject.Parse(response.Content);
            return obj[responseObjct].ToString();
        }


        public static async Task<IRestResponse<T>> ExecuteAsyncRequest<T>(this RestClient c,
            RestClient client, IRestRequest request) where T : class, new()
        {
            var taskCompletionSourse = new TaskCompletionSource<IRestResponse<T>>();
            client.ExecuteAsync<T>(request, restResponse =>
            {
                if (restResponse.ErrorException != null)
                {
                    const string message = "Error in response";
                    throw new ApplicationException(message, restResponse.ErrorException);
                }
                taskCompletionSourse.SetResult(restResponse);
            });
            return await taskCompletionSourse.Task;
        }
    }
}
