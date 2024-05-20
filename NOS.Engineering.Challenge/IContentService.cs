using NOS.Engineering.Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOS.Engineering.Challenge
{
    public interface IContentService
    {
        Task<IEnumerable<Content>> GetAllContentsAsync();
        Task<Content> GetContentByIdAsync(Guid id);
        Task AddContentAsync(Content content);
        Task UpdateContentAsync(Content content);
        Task DeleteContentAsync(Guid id);
    }
}
