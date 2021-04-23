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
    public class CommentAPI
    {
       

        public async Task<List<Comment>> CommentGetAll()
        {
            List<Comment> comments = new List<Comment>();
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(Utilities.URLComment);

                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("comments");

                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var Comments = Res.Content.ReadAsStringAsync().Result;
                        // Deserializing the response recieved from web api and storing into the  list
                        comments = JsonConvert.DeserializeObject<List<Comment>>(Comments);


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message.ToString());
            }
            

            return comments;

        }

       
    }
}
