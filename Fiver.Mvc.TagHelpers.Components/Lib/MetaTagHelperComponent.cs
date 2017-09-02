using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Fiver.Mvc.TagHelpers.Components.Lib
{
    public class MetaTagHelperComponent : TagHelperComponent
    {
        public override int Order => 1;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml($"<meta name=\"description\" content=\"I was generated on the fly\" /> \r\n");
            }
        }
    }
}
