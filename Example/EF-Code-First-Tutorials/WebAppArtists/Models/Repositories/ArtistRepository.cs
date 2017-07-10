using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppArtists.Models.Repositories
{
    //with this class we inherit Repository Class and we want to use T as Artist Class that is why in Repository<T> we put <Artist> and we will use those methods we want from Repository Class
    public class ArtistRepository: Repository<Artist>
    {
        //here we use GetAll method and we specified which rows we want we want all rows that have name value 
        public List<Artist >GetByName(string Name)
        {
            //here we want to select all the artist that has name
            return DbSets.Where(a => a.Name.Contains(Name)).ToList();
        }
    }
}