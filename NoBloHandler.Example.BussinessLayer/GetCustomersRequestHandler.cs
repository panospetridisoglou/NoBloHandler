using NoBloHandler.Core.Abstractions;
using NoBloHandler.Example.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBloHandler.Example.BussinessLayer
{
	public class GetCustomersRequestHandler : INoBloHandler<GetCustomersRequest, object>
	{
		private readonly CustomersRepository _customersRepository;

		public GetCustomersRequestHandler(CustomersRepository customersRepository)
		{
			_customersRepository = customersRepository;
		}
		public async Task<object> HandleAsync(GetCustomersRequest request, CancellationToken token)
		{
			_customersRepository.GetCustomers();
			Console.WriteLine("Handling "+nameof(GetCustomersRequest));
			return await Task.FromResult(new object());
		}
	}
}
