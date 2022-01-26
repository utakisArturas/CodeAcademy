using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0124
{
    internal class TvProgramme
    {   

        public List<TvShow> TvProgrammes = new List<TvShow>();
        public TvProgramme()
        {
            
        }
       public void AddTvShow(TvShow show)
        {
            TvProgrammes.Add(show);
        }
        public void RemoveTvShowByName(string title)
        {   
            
            foreach (TvShow tvShow in TvProgrammes)
            {
                if (tvShow.Title == title)
                {
                    TvProgrammes.Remove(tvShow);
                    break;
                }
            }
        }
        public void RemoveTvShowByID(int id)
        {
            foreach (TvShow tvShow in TvProgrammes)
            {
                if (tvShow.Id == id )
                {
                    TvProgrammes.Remove(tvShow);
                    break;
                }
            }
        }
        public void PrintProgramme()
        {
            foreach (TvShow tvShow in TvProgrammes)
            {
                Console.WriteLine(tvShow);
            }
        }
        public void ClearProgramme()
        {
            TvProgrammes.Clear();
        }

    }
}
