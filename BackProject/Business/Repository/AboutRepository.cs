using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using DAL.Data;
using DAL.Models;
using Exceptions.Entity;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class AboutRepository : IAboutService
    {
        private readonly AppDbContext _context;
        public AboutRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<About> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException("id");
            }
            var data = await _context.About.Where(n => n.Id == id && !n.IsDeleted)
                                             .Include(n => n.Image)
                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;

        }
        public async Task<List<About>> GetAll()

        {
            var data = await _context.About.Where(n => !n.IsDeleted).Include(n => n.Image).ToListAsync();
            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Create(About entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.About.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, About entity)
        {
            var data = await Get(id);
            data.Title = entity.Title;
            data.Context = entity.Context;
            data.Quote = entity.Quote;
            data.ImageId = entity.ImageId;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
    }
}

