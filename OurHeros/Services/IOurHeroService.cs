using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OurHeros.Model;

namespace OurHeros.Services
{
    public interface IOurHeroService
    {
        List<OurHero> GetAllHeros(bool? isActive);

        OurHero? GetHerosByID(int id);

        OurHero AddOurHero(AddUpdateOurHero obj);

        OurHero? UpdateOurHero(int id, AddUpdateOurHero obj);

        bool DeleteHerosByID(int id);
    }
}