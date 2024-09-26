namespace NoBloHandler.Core.Abstractions
{
	public interface INoBloHandler;
	public interface INoBloHandler<T, R> : INoBloHandler where T : class where R:class
	{
		Task<R> HandleAsync(T request,CancellationToken token);
	}
}
