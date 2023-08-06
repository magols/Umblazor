using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmblazorWeb.Models;

public class UmbracoPageComponent<T> where T : PublishedContentModel
{
    public T Model { get; set; }

}