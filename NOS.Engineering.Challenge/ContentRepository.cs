using Microsoft.EntityFrameworkCore;
using NOS.Engineering.Challenge.Database;
using NOS.Engineering.Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOS.Engineering.Challenge
{
    public class ContentRepository : IContentRepository
    {
        private readonly ApplicationDbContext _context;

        public ContentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Content>> GetAllAsync()
        {
            return await _context.Contents.ToListAsync();
        }

        public async Task<Content> GetByIdAsync(Guid id)
        {
            return await _context.Contents.FindAsync(id);
        }

        public async Task AddAsync(Content content)
        {
            await _context.Contents.AddAsync(content);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Content content)
        {
            _context.Contents.Update(content);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var content = await _context.Contents.FindAsync(id);
            if (content != null)
            {
                _context.Contents.Remove(content);
                await _context.SaveChangesAsync();
            }
        }
    }

}
