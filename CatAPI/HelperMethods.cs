using System;
using System.Collections.Generic;
using System.Linq;
using ApiClient;

namespace CatAPI
{
    public class Helpers
    {
        public List<CatModel> cachedCatList = new List<CatModel>(); // reikalingas listo modifikacijoms
        public List<CatModel> backedUpCatList = new List<CatModel>(); // reikalingas originalaus listo atstatimui
        public List<CatModel> filteredList = new List<CatModel>(); // reikalingas filtru listui

        public List<CatModel> SaveCatsToCache()
        {
            string requestedData = ApiHelper.RequestListFromWebApi(); // padarytas tiktai kad istestuoti parsinima
            cachedCatList = ApiHelper.GetCats(requestedData); // List yra reference type, todel reikia kitaip kopijuoti
            //catListBackup = cachedCatList; // Negalima, nes tai yra reference type, reikia daryti deep cloning
            //catListBackup = ApiHelper.GetCats(); // Antra karta panaudos ApiHelper, todel negalima
            return cachedCatList;
        }

        public static List<CatModel> BackUpCats(List<CatModel> lyst)
        {
            if (!lyst.Any())
            {
                throw new InvalidOperationException("List contains no objects");
            }
            List<CatModel> backedUpCatList = new List<CatModel>();
            foreach (var v in lyst)
            {
                backedUpCatList.Add(new CatModel
                {
                    weight = v.weight,
                    id = v.id,
                    name = v.name,
                    cfa_url = v.cfa_url,
                    vetstreet_url = v.vetstreet_url,
                    vcahospitals_url = v.vcahospitals_url,
                    temperament = v.temperament,
                    origin = v.origin,
                    country_codes = v.country_codes,
                    country_code = v.country_code,
                    description = v.description,
                    life_span = v.life_span,
                    indoor = v.indoor,
                    lap = v.lap,
                    alt_names = v.alt_names,
                    adaptability = v.adaptability,
                    affection_level = v.affection_level,
                    child_friendly = v.child_friendly,
                    dog_friendly = v.dog_friendly,
                    energy_level = v.energy_level,
                    grooming = v.grooming,
                    health_issues = v.health_issues,
                    intelligence = v.intelligence,
                    shedding_level = v.shedding_level,
                    social_needs = v.social_needs,
                    stranger_friendly = v.stranger_friendly,
                    vocalisation = v.vocalisation,
                    experimental = v.experimental,
                    hairless = v.hairless,
                    natural = v.natural,
                    rare = v.rare,
                    rex = v.rex,
                    suppressed_tail = v.suppressed_tail,
                    short_legs = v.short_legs,
                    wikipedia_url = v.wikipedia_url,
                    hypoallergenic = v.hypoallergenic,
                    reference_image_id = v.reference_image_id,
                    cat_friendly = v.cat_friendly,
                    bidability = v.bidability
                });
            }
            return backedUpCatList;
        }

        public static List<CatModel> MakeUpperCase(List<CatModel> lyst)
        {
            if (!lyst.Any())
            {
                throw new InvalidOperationException("List contains no objects");
            }
            lyst.ForEach(z =>
            {
                z.name = z.name.ToUpper();
            });
            return lyst;
        }

        public static List<CatModel> MakeLowerCase(List<CatModel> lyst)
        {
            if (!lyst.Any())
            {
                throw new InvalidOperationException("List contains no objects");
            }
            lyst.ForEach(z =>
            {
                z.name = z.name.ToLower();
            });
            return lyst;
        }

        public static List<CatModel> FilteringByQuality(List<CatModel> lyst, string quality)
        {
            if (!lyst.Any())
            {
                throw new InvalidOperationException("List contains no objects");
            }
            List<CatModel> filteredLyst = new List<CatModel>();
            switch (quality)
            {
                case "child_friendly":
                    foreach (var cat in lyst)
                    {
                        if (cat.child_friendly >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                case "grooming":
                    foreach (var cat in lyst)
                    {
                        if (cat.grooming >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                case "health_issues":
                    foreach (var cat in lyst)
                    {
                        if (cat.health_issues >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                case "energy_level":
                    foreach (var cat in lyst)
                    {
                        if (cat.energy_level >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                case "intelligence":
                    foreach (var cat in lyst)
                    {
                        if (cat.intelligence >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                case "vocalisation":
                    foreach (var cat in lyst)
                    {
                        if (cat.vocalisation >= 4)
                        {
                            filteredLyst.Add(cat);
                        }
                    }
                    return filteredLyst;
                default:
                    Console.WriteLine("No matches.");
                    break;
            }
            return lyst;
        }

    }
}
