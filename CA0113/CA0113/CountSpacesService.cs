using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0113
{
    internal class CountSpacesService
    {
        public void SpaceCount(string text)
        {
            int countSpaces = text.Count(Char.IsWhiteSpace);
            Console.WriteLine($"Number of spaces: {countSpaces}");
        }
    }
}
