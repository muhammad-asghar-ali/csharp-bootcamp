using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OurHeros.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace OurHeros.Services
{
    public class OurHeroService(OurHeroDbContext db) : IOurHeroService
    {
        private readonly OurHeroDbContext _db = db;

        public async Task<List<OurHero>> GetAllHeros(bool? isActive)
        {
            if (isActive == null) { return await _db.OurHeros.ToListAsync(); }

            return await _db.OurHeros.Where(obj => obj.IsActive == isActive).ToListAsync();
        }

        public async Task<OurHero?> GetHerosByID(int id)
        {
            return await _db.OurHeros.FirstOrDefaultAsync(hero => hero.Id == id);
        }

        public async Task<OurHero?> AddOurHero(AddUpdateOurHero obj)
        {
            var addHero = new OurHero()
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                IsActive = obj.IsActive,
            };

            _db.OurHeros.Add(addHero);
            var result = await _db.SaveChangesAsync();
            return result >= 0 ? addHero : null;
        }

        public async Task<OurHero?> UpdateOurHero(int id, AddUpdateOurHero obj)
        {
            var hero = await _db.OurHeros.FirstOrDefaultAsync(index => index.Id == id);
            if (hero != null)
            {
                hero.FirstName = obj.FirstName;
                hero.LastName = obj.LastName;
                hero.IsActive = obj.IsActive;

                var result = await _db.SaveChangesAsync();
                return result >= 0 ? hero : null;
            }
            return null;
        }

        public async Task<bool> DeleteHerosByID(int id)
        {
            var hero = await _db.OurHeros.FirstOrDefaultAsync(index => index.Id == id);
            if (hero != null)
            {
                _db.OurHeros.Remove(hero);
                var result = await _db.SaveChangesAsync();
                return result >= 0;
            }
            return false;
        }
    }
}