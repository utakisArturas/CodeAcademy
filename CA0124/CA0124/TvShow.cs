using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0124
{
    internal class TvShow
    {
        public int Id;
        public TimeSpan Duration;
        public string Title;
        public string Description;
        public DateTime StartTime;

        public TvShow(int id, TimeSpan duration, string title, string description, DateTime startTime)
        {
            Id = id;
            Duration = duration;
            Title = title;
            Description = description;
            StartTime = startTime;
        }
        public override string ToString()
        {
            return $"{Id} {Duration} {Title} {Description} {StartTime}";
        }
    }
}
