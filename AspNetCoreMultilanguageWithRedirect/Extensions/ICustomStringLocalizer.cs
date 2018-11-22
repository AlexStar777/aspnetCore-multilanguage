using Microsoft.Extensions.Localization;

namespace AspNetCoreMultilanguageWithRedirect.Extensions
{
    public interface ICustomStringLocalizer : IStringLocalizer
    {
        LocalizedString GetLocalizedHtmlString(string key);
    }
}
