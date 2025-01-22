using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Opss.DesignSystem.Frontend.Showcase.Pages
{
    [SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "This is the viewmodel for Error.cshml, so it is instantiated, but by asp.net.")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    internal sealed class ErrorModel : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
#pragma warning restore CA1812