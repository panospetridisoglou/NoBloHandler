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
		public async Task<object> HandleAsync(InsertNewCustomerCommand request, CancellationToken token)
		{
			Console.WriteLine("Handling "+nameof(InsertNewCustomerCommand));
			return await Task.FromResult(new object());
		}
	}
}
