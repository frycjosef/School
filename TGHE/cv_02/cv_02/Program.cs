using System;
using System.Collections.Generic;
using System.Text;

namespace cv_02
{
    class Program
    {

        static int counter = 1;
        static void Main(string[] args)
        {
            //1  2  3  4  5  6  7  8
            int[,] incidenceMatrix = new int[,]{    {1, 0, 1, 0 ,0 ,0 ,0 ,0 },//A
                                                    {1, 1, 0, 1, 0, 0, 0, 0 },//B
                                                    {0, 1, 0, 0, 1, 0, 0, 0 },//C
                                                    {0, 0, 1, 0, 0, 1, 1, 1 },//D
                                                    {0, 0, 0, 1, 0, 1, 0, 0 },//E
                                                    {0, 0, 0, 0, 1, 0, 0, 0 },//F
                                                    {0, 0, 0, 0, 0, 0, 1, 0 },//G
                                                    {0, 0, 0, 0, 0, 0, 0, 1 } //H
            };

            Dictionary<int, Node> path = new Dictionary<int, Node>();
            path[0] = new Node("A");
            path[1] = new Node("B");
            path[2] = new Node("C");
            path[3] = new Node("D");
            path[4] = new Node("E");
            path[5] = new Node("F");
            path[6] = new Node("G");
            path[7] = new Node("H");
            int level = 0;
            int counter = 1;

            //Console.WriteLine(path.Count);
            DFS(incidenceMatrix, path, counter, level);

            for (int i = 0; i < path.Count; i++)
            {
                Console.WriteLine(path[i].getName() + " (" + path[i].getFirst() + "," + path[i].getSecond() + ")");
            }
            Console.ReadKey();
        
        }

        public static int DFS(int[,] matrix, Dictionary<int,Node> path, int counter, int level)
        {
            path[level].setFirst(counter);
            Console.WriteLine("Seting first " + path[level].getName() + " to " + counter);
            for (int i=0; i <= matrix.GetUpperBound(1); i++)
            {
                if (i != level)
                {
                    for(int j=0; j <= matrix.GetUpperBound(0); j++)
                    {
                        if (matrix[i,j] == matrix[level,j] && matrix[level,j]==1 && path[i].getFirst()<=0)
                        {
                            if (!path[i].wasVisited())
                            {
                                path[i].setVisited();
                                counter=DFS(matrix, path, counter+1,i);
                               
                            }
                           
                        }
                    }
                }
            }
            path[level].setSecond(counter);
            Console.WriteLine("Seting second" + path[level].getName() + " to " + counter);
            return counter;
        }
    }

}
