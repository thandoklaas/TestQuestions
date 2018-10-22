using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Questions
{
    public static class Question4
    {
        public const string Title = "Working with JSON (30 min)";

        public static void Login()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Login
            // 2. Use the token received from the login for the Get, Put, Delete and List:
            // 3. Write the output to the console

            var result = "";
            const string url = "https://reqres.in/api/login";

            var jsonString = new JavaScriptSerializer().Serialize(new
            {
                email = "peter@klaven",
                password = "cityslicka"
            });

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.UploadString(url, "POST", jsonString);
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--Login Function--");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("--Test Completed--");
        }

        public static void Post()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Preform relevant function on a  user

            var result = "";
            const string url = "https://reqres.in/api/users";

            var jsonString = new JavaScriptSerializer().Serialize(new
            {
                name = "morpheus",
                job = "leader"
            });

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.UploadString(url, "POST", jsonString);
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--Post Function--");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("--Test Completed--");
        }

        public static void Get()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Preform relevant function on a  user

            var result = "";
            const string url = "https://reqres.in/api/users/2";

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.DownloadString(url);
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--Get Function--");
            Console.WriteLine();
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("--Test Completed--");
        }

        public static void Put()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Preform relevant function on a  user

            var result = "";
            const string url = "https://reqres.in/api/users/2";

            var jsonString = new JavaScriptSerializer().Serialize(new
            {
                name = "morpheus",
                job = "zion resident"
            });

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.UploadString(url, "PUT", jsonString);
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--Put Function--");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("--Test Completed--");
        }

        public static void Delete()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Preform relevant function on a  user
            var result = "";
            const string url = "https://reqres.in/api/users/2";


            var jsonString = new JavaScriptSerializer().Serialize(new
            {
                //name = "morpheus",
                //job = "zion resident"
            });
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result =  client.DownloadString(url);
           
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--Delete Function--");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--Test Not Completed--");
        }

        public static void List()
        {
            // Using Requires at https://reqres.in/ as your input data, write a rest based service that:

            // 1. Preform relevant function on all users /api/users?page=2
            var result = "";
            const string url = "https://reqres.in/api/users?page=2";

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.Encoding = Encoding.UTF8;
                result = client.DownloadString(url);
            }

            dynamic jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

            Console.WriteLine("--List Function--");
            foreach (var item in jsonResult)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--Test Completed--");
        }
    }
}
