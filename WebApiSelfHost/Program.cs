using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApiSelfHost
{
	class Program
	{
		static void Main(string[] args)
		{
			var config = new HttpSelfHostConfiguration("http://localhost:9004");
			config.Routes.MapHttpRoute("default",
				"api/{controller}/{id}",
				new { controller = "Home", id = RouteParameter.Optional });

			var server = new HttpSelfHostServer(config);
			var task = server.OpenAsync();
			task.Wait();

			Console.WriteLine("Web API Server has started at http://localhost:9004");
			Console.ReadLine();
        }
	}
}
