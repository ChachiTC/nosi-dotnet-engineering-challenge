using NOS.Engineering.Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOS.Engineering.Challenge
{
    public class ContentService : IContentService
    {
        private readonly IContentRepository _contentRepository;

        public ContentService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<IEnumerable<Content>> GetAllContentsAsync()
        {
            return await _contentRepository.GetAllAsync();
        }

        public async Task<Content> GetContentByIdAsync(Guid id)
        {
            return await _contentRepository.GetByIdAsync(id);
        }

        public async Task AddContentAsync(Content content)
        {
            await _contentRepository.AddAsync(content);
        }

        public async Task UpdateContentAsync(Content content)
        {
            await _contentRepository.UpdateAsync(content);
        }

        public async Task DeleteContentAsync(Guid id)
        {
            await _contentRepository.DeleteAsync(id);
        }
    }
}
