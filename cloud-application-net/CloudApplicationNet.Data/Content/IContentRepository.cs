using System.Collections.Generic;

namespace CloudApplicationNet.Data.Content
{
    public interface IContentRepository
    {
        ICollection<ContentItem> GetItems(string path);
    }
}