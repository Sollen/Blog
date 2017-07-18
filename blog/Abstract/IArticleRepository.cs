using System.Collections.Generic;
using WebUI.Models;

namespace WebUI.Abstract
{
    public interface IArticleRepository
    {
        IEnumerable<Article> Articles { get; }
    }
}
