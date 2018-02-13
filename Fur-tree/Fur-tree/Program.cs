using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fur_tree
{
    class Program
    {
        private static StringBuilder furTree;
        private static string space;
        private static int stepRight;
        private static int stepLeft;
        static void Main(string[] args)
        {
            furTree = new StringBuilder("");
            Console.WriteLine("Build Fur-Tree !!!\n", Console.Title);
            for (int i = 0; i < 100; i++)
                space += " ";
            furTree.Append(space);
            stepLeft = furTree.Length / 2 + 1;
            stepRight = furTree.Length / 2 - 1;
            BuildFurTree();
        }

        private static void BuildFurTree()
        {
            stepRight++;
            furTree.Replace(' ', '*', stepRight, 1);
            stepLeft--;
            furTree.Replace(' ', '*', stepLeft, 1);
            Console.WriteLine(furTree);
            if (stepRight < 99)
                BuildFurTree();
        }
    }
}
