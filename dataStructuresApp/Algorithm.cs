using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructuresApp
{
   public class Algorithm
   {
        //constructor
        public Algorithm()
        {

        }

        public bool ValidateSmart(Graph g, int[] cover, int n, int i, int k)
        {
            if (k > n)
                return false;
            if (!g.getOk())
                return true;
            if (i == n)
            {
                //Console.WriteLine("entering validate from smart part");
                return (g.ValidateSmart(cover, n, k));
            }
            else
            {
                if (cover[i] == 0 || cover[i] == 1)
                {
                    if (g.getPendants().Contains(i) || g.getIsolatedVertices().Contains(i))
                    {
                        cover[i] = 0; //last minute change
                       ValidateSmart(g, cover, n, i + 1, k);
                        if (!g.getOk())
                            return true;
                    }
                    else
                    {
                        cover[i] = 0;
                        ValidateSmart(g, cover, n, i + 1, k);
                        if (!g.getOk())
                            return true;

                        cover[i] = 1;
                        ValidateSmart(g, cover, n, i + 1, k);
                        if (!g.getOk())
                            return true;
                    }
                }
                else if (cover[i] == 2)
                {
                    
                    ValidateSmart(g, cover, n, i + 1, k);
                    if (!g.getOk())
                        return true;
                }                
            }
            return false;
        }

        //BRUTE FORCE SEARCH
        public bool Validate(Graph g, bool[] cover, int n, int i, int k)
        {
            if (k > n)
                return false;
            if (!g.getOk())
                return true;
            if (i == n)
            {               
                return (g.Validate(cover, n, k));
            }
            else
            {               
                cover[i] = false;
                Validate(g, cover, n, i + 1, k);
                if (!g.getOk())
                    return true;

                cover[i] = true;
                Validate(g, cover, n, i + 1, k);
                if (!g.getOk())
                    return true;                
            }
            return false;
        }

        public void ValidateAprox(Graph g, int vertices)
        {
            int[] assignment = new int[vertices];
            List<int> cover=new List<int>();
            bool valid = false;

            while (!valid)
            {
                //look for vertex with most uncovered edges
                int candidateIndex = 0;
                int maxUncoveredNeighbours = 0;

                for (int i = 0; i < vertices; i++)
                {
                    // vertex with 1 already covers adjacent edges
                    if(assignment[i] !=1)
                    {
                        int sumUncovered = 0;
                        for (int j = 0; j < vertices; j++)
                        {
                            if (g.getAdjListArray()[i].Contains(j) && assignment[j] != 1)
                                sumUncovered++;
                        }
                        if(sumUncovered>maxUncoveredNeighbours)
                        {
                            candidateIndex = i;
                            maxUncoveredNeighbours = sumUncovered;
                        }
                    }
                }
                //if not found then exit, otherwise add to cover
                if (maxUncoveredNeighbours == 0)
                    valid = true;
                else
                {
                    cover.Add(candidateIndex);
                    assignment[candidateIndex] = 1;
                }
            }
            // size of cover and print
            int size = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (assignment[i] == 1)
                    size++;
            }
           
            Console.Write("Vertices in the cover:");
            foreach (int number in cover)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine();
            Console.WriteLine("Size: " + size);

            Console.WriteLine();
        }
    }
}
