using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamBanque.DTO;

namespace XamBanque.WebServices
{
    public class RestServices
    {

        static HttpClient client = new HttpClient();
        static string baseUrl = "http://172.20.70.72:8080/xambank";

        public static async Task<UserDTO> connectionAsync(LoginDTO loginDto)
        {

            string finalUrl = baseUrl + "/user/login";
            var data = JsonConvert.SerializeObject(loginDto);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(finalUrl, content);
            UserDTO result = JsonConvert.DeserializeObject<UserDTO>(response.Content.ReadAsStringAsync().Result);

            return result;
        }
    }
}
