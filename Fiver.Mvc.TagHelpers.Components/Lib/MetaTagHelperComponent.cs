using Fiver.Mvc.TagHelpers.Components.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Fiver.Mvc.TagHelpers.Components.Lib
{
    //public class MetaTagHelperComponent : TagHelperComponent
    //{
    //    public override int Order => 1;

    //    public override void Process(TagHelperContext context, TagHelperOutput output)
    //    {
    //        if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
    //        {
    //            output.PostContent.AppendHtml(
    //                $"<meta name=\"description\" content=\"This is a post on TagHelperComponent\" /> \r\n");
    //            output.PostContent.AppendHtml(
    //                $"<meta name=\"keywords\" content=\"asp.net core, mvc, tag helpers\" /> \r\n");
    //        }
    //    }
    //}

    public class MetaTagHelperComponent : TagHelperComponent
    {
        private readonly IMetaService service;

        public MetaTagHelperComponent(IMetaService service)
        {
            this.service = service;
        }

        public override int Order => 1;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var item in this.service.GetMetadata())
                    output.PostContent.AppendHtml(
                        $"<meta name=\"{item.Key}\" content=\"{item.Value}\" /> \r\n");
            }
        }
    }
}
