using NOS.Engineering.Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOS.Engineering.Challenge
{
        public interface IContentRepository
        {
            Task<IEnumerable<Content>> GetAllAsync();
            Task<Content> GetByIdAsync(Guid id);
            Task AddAsync(Content content);
            Task UpdateAsync(Content content);
            Task DeleteAsync(Guid id);
        }
    
}
