namespace Opss.DesignSystem.Frontend.Blazor.UnitTests.Helpers
{
	public static class RenderExtensions
	{
        /// <summary>
        /// bUnit MarkupMatches doesn't recognise the hidden unicode character \uFEFF that is added
        /// to markup by Blazor when using CascadingValue. Replace this with nothing so bUnit passes.
        /// </summary>
        /// <param name="component">The component to extract the Markup from</param>
        /// <returns>Markup without hidden \uFEFF character</returns>
        public static string bUnitMarkup(this IRenderedComponent<Bunit.Rendering.ContainerFragment> component)
        {
            return component.Markup.Replace("\uFEFF", "");
        }
	}
}