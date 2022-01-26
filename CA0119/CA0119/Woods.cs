using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0119
{
    internal class Woods
    {
        public List<int> trees;
        public Woods()
        {
            trees = new List<int>();

        }
        public void PlantATree(int HowManyTrees)
        {
            for (int i = 0; i < HowManyTrees; i++)
            {
                trees.Add(i);
            }

        }
    }
}
