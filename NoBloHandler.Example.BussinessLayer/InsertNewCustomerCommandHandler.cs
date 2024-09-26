using NoBloHandler.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBloHandler.Example.BussinessLayer
{
	public class InsertNewCustomerCommandHandler : INoBloHandler<InsertNewCustomerCommand, object>
	{
		public Task<object> HandleAsync(InsertNewCustomerCommand request, CancellationToken token)
		{
			Console.WriteLine("Handling "+nameof(InsertNewCustomerCommand));
			return null;
		}
	}
}
