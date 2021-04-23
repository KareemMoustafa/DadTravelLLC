
using System.Configuration;
using System.Web.Configuration;

namespace DadabhaiTravelLLC.Utilities
{
    public  class Utilities
    {

       public static string URLComment = ConfigurationManager.AppSettings["URLComment"]; 
       public static string URLTodo = ConfigurationManager.AppSettings["URLTodo"];
       public static string URLFood = ConfigurationManager.AppSettings["URLComment"];



    }
}