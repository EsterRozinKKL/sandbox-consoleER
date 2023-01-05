using System.Text;
using System.Text.Json;

namespace sandbox_console;
class Program
{
     public static async Task<string>  GetTmpToken()
        {
            try{
      var obj = new TokenParam();

                obj.client_id = "mg8u3pah8i07t3q";
                obj.grant_type = "authorization_code";
                obj.code = "wfciaQjl2ywAAAAAAAAAaEmtBd_qFT3GRACxiYBATJA";
                obj.client_secret = "o7vwlxkjz0ibgrw";
                var jsonString = JsonSerializer.Serialize(obj);

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Length", "84");
               // httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Host", "envoy");

                using (var response = httpClient.PostAsync("https://api.dropboxapi.com/oauth2/token", new StringContent(jsonString, Encoding.UTF8, "application/json")))
                {
                    var aaa = response.Result;
                    var aaz = new System.IO.StreamReader(aaa.Content.ReadAsStream()).ReadToEnd();
                }
            }
            return "";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GetTmpToken();
    }
}
