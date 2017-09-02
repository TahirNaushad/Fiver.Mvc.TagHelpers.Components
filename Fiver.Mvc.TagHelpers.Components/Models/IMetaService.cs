using System.Collections.Generic;

namespace Fiver.Mvc.TagHelpers.Components.Models
{
    public interface IMetaService
    {
        Dictionary<string, string> GetMetadata();
    }
}