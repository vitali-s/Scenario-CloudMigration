using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CloudApplicationNet.Data.Content
{
    public class ContentRepository : IContentRepository
    {
        public ICollection<ContentItem> GetItems(string path)
        {
            ICollection<ContentItem> files = new DirectoryInfo(path)
                .GetFiles()
                .Select(file => new ContentItem { Name = file.Name})
                .ToList();

            return files;
        }
    }
}
