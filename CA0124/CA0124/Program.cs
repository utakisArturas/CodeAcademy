using System;

namespace CA0124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TvShow1 = new TvShow(1,new TimeSpan(1,0,0),"Doctor House","Tv series about doctor",new DateTime(2021,01,25,18,15,00));
            var TvShow2 = new TvShow(2, new TimeSpan(2, 5, 0), "LOTR", "Movie about a ring", new DateTime(2021, 01, 26, 21, 00, 00));

            var Tvprogramme = new TvProgramme();
            Tvprogramme.AddTvShow(TvShow1);
            Tvprogramme.AddTvShow(TvShow2);
            Tvprogramme.PrintProgramme();
            Tvprogramme.ClearProgramme();
            Tvprogramme.AddTvShow(TvShow1);
            Tvprogramme.AddTvShow(TvShow2);
            Tvprogramme.RemoveTvShowByID(2);
            Tvprogramme.PrintProgramme();


        }
    }
}
