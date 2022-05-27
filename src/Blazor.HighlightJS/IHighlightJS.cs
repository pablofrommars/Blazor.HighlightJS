namespace Blazor.HighlightJS;

public interface IHighlightJS : IAsyncDisposable
{
	ValueTask HighlightElement(ElementReference element);
}