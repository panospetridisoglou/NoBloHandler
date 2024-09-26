using NoBloHandler.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBloHandler.Example.BussinessLayer
{
	public class GetCustomersRequestHandler : INoBloHandler<GetCustomersRequest, object>
	{
		public Task<object> HandleAsync(GetCustomersRequest request, CancellationToken token)
		{
			Console.WriteLine("Handling "+nameof(GetCustomersRequest));
			return null;
		}
	}
}
