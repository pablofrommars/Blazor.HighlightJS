using Blazor.HighlightJS;

namespace Microsoft.Extensions.DependencyInjection;

public static class IServiceCollectionExtensions
{
	public static IServiceCollection AddHighlightJS(this IServiceCollection services)
		=> services.AddScoped<IHighlightJS, HighlightJS>();
}