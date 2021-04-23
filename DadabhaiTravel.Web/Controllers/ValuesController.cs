using DadabhaiTravel.API;
using DadabhaiTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DadabhaiTravel.Web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<Comment>> GetComments()
        {
            CommentAPI _commenAPI = new CommentAPI();
           return await _commenAPI.CommentGetAll();
        }

        // GET api/values
        public async Task<IEnumerable<Todo>> GetTodos()
        {
            TodoAPI _TodoAPi = new TodoAPI();
            return await _TodoAPi.TodoGetAll();
        }


    }
}
