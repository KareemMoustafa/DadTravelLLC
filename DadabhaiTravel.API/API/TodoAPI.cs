using DadabhaiTravel.Models;
using DadabhaiTravelLLC.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DadabhaiTravel.API
{
    public class TodoAPI
    {

        public async Task<List<Todo>> TodoGetAll()
        {
            List<Todo> todolst = new List<Todo>();

            try
            {
                using (var client = new HttpClient())
                {
                    //Passing service base url  
                    client.BaseAddress = new Uri(Utilities.URLTodo);
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("todos");
         

                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var Todos = Res.Content.ReadAsStringAsync().Result;
                        // Deserializing the response recieved from web api and storing into the  list
                        todolst = JsonConvert.DeserializeObject<List<Todo>>(Todos);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message.ToString());
            }
           

            return todolst;

        }

    }
}
