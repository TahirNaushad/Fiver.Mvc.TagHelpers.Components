using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace Fiver.Mvc.TagHelpers.Components.Lib
{
    [HtmlTargetElement("footer")]
    public class FooterTagHelper : TagHelperComponentTagHelper
    {
        public FooterTagHelper(
            ITagHelperComponentManager manager,
            ILoggerFactory logger) : base(manager, logger) { }
    }
}
