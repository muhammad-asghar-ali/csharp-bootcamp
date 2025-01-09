using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OurHeros.Model;

namespace OurHeros.Services
{
    public class OurHeroService : IOurHeroService
    {
        private readonly List<OurHero> _ourHeroesList;

        public OurHeroService()
        {
            _ourHeroesList =
            [
                new(){
                Id = 1,
                FirstName = "Test",
                LastName = "",
                IsActive = true,
                }
            ];
        }

        public OurHero AddOurHero(AddUpdateOurHero obj)
        {
            var addHero = new OurHero()
            {
                Id = _ourHeroesList.Max(hero => hero.Id) + 1,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                IsActive = obj.IsActive,
            };

            _ourHeroesList.Add(addHero);

            return addHero;
        }

        public List<OurHero> GetAllHeros(bool? isActive)
        {
            return isActive == null ? _ourHeroesList : _ourHeroesList.Where(hero => hero.IsActive == isActive).ToList();
        }

        public OurHero? GetHerosByID(int id)
        {
            return _ourHeroesList.FirstOrDefault(hero => hero.Id == id);
        }

        public OurHero? UpdateOurHero(int id, AddUpdateOurHero obj)
        {
            var ourHeroIndex = _ourHeroesList.FindIndex(index => index.Id == id);
            if (ourHeroIndex > 0)
            {
                var hero = _ourHeroesList[ourHeroIndex];

                hero.FirstName = obj.FirstName;
                hero.LastName = obj.LastName;
                hero.IsActive = obj.IsActive;

                _ourHeroesList[ourHeroIndex] = hero;

                return hero;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteHerosByID(int id)
        {
            var ourHeroIndex = _ourHeroesList.FindIndex(index => index.Id == id);
            if (ourHeroIndex >= 0)
            {
                _ourHeroesList.RemoveAt(ourHeroIndex);
            }
            return ourHeroIndex >= 0;
        }
    }
}