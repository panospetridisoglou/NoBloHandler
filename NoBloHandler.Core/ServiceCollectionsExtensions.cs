using Microsoft.Extensions.DependencyInjection;
using NoBloHandler.Core.Abstractions;
using System.Reflection;

namespace NoBloHandler.Core
{
	public  static class ServiceCollectionsExtensions
	{
		public static IServiceCollection AddNoBloHandlers(this IServiceCollection services,Assembly assembly) {


			foreach (Type mytype in assembly.GetTypes()
				.Where(mytype => mytype.GetInterfaces().Contains(typeof(INoBloHandler))))
			{

				services.AddTransient(mytype.GetInterfaces()[0], mytype);
				Console.WriteLine($"added {mytype.Name}");
			}

			return services;
		}
	}
}
