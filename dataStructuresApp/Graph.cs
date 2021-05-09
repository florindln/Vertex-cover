using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace dataStructuresApp
{
    public class Graph
    {
        Random randomNr = new Random();
        // A user define class to represent a graph.
        // A graph is an array of adjacency lists.
        // Size of array will be V (number of vertices
        // in graph)
        int vertices;
        List<List<int>> adjListArray;
        List<int> verticesToConnect = new List<int>();

        List<int> tops = new List<int>();
        List<int> pendants = new List<int>();
        List<int> isolatedVertices = new List<int>();


        public List<List<int>> getAdjListArray()
        {
            return adjListArray;
        }

        public List<int> getTops()
        {
            return tops;
        }
        public List<int> getPendants()
        {
            return pendants;
        }
        public List<int> getIsolatedVertices()
        {
            return isolatedVertices;
        }

        bool ok = true;
        public bool getOk() { return ok; }
        public void setOk(bool ok) { this.ok = ok; }

        // constructor
        public void initializeGraph(int V)
        {
            this.vertices = V;
            // define the size of array as
            // number of vertices
            adjListArray = new List<List<int>>();

            // Create a new list for each vertex
            // such that adjacent nodes can be stored

            for (int i = 0; i < V; i++)
            {
                adjListArray.Add(new List<int>());
            }

        }

        public void kernelization(int k)
        {
            Console.WriteLine();
            findPendants();
            findTops(k);
            findIsolated();
        }

        private void findPendants()
        {
            pendants.Clear();
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count == 1)
                {
                    Console.WriteLine("found pendant" + i);
                    if (!pendants.Contains(i))
                    {
                        bool ok = true;
                        foreach (int pendant in pendants)
                        {
                            if (adjListArray[pendant].Contains(i))
                                ok = false;
                        }
                        if(ok) pendants.Add(i);
                    }
                }
            }
        }
        private void findTops(int k)
        {
            tops.Clear();
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count > k)
                {
                    Console.WriteLine("found top" + i);
                    if (!tops.Contains(i))
                        tops.Add(i);
                }
            }
        }
        private void findIsolated()
        {
            isolatedVertices.Clear();
            for (int i = 0; i < vertices; i++)
            {
                if (!adjListArray[i].Any())
                {
                    Console.WriteLine("found isolated" + i);
                    if (!isolatedVertices.Contains(i))
                        isolatedVertices.Add(i);
                }
            }

            /* foreach (int i in isolatedVertices)
             {
                 Console.WriteLine(i);
             }*/
        }

        //selects an arbitrary *pendant* vertex and makes it a *non* pendant by *adding* arbitrary edges
        public void makeNonPendant()
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count == 1)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjListArray[i].Count == 1)
                        {
                            if (addEdge(i, j))
                            {
                                
                                Console.WriteLine();
                                Console.WriteLine("Connected " + i + " to " + j);
                                Console.WriteLine();
                                break;
                            }
                        }
                    }
                    if (pendants.Contains(i))
                        pendants.Remove(i);
                    break;
                }
            }
            //foreach (List<int> list in adjListArray)
            //{
            //    if (list.Count==1)
            //    {
            //        list.Add(0);
            //        Console.WriteLine("Connected 0 to "+ )
            //        break;
            //    }
            //}

        }
        //selects an arbitrary *non-pendant* vertex and makes it a pendant by *removing* arbitrary edges
        public void makePendant()
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count > 1)
                {
                    // while (adjListArray[i].Count > 1)
                    //{
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjListArray[i].Count > 1)
                        {
                            if (removeEdge(i, j))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Removed " + i + " to " + j);
                                Console.WriteLine();
                                //break;
                            }
                        }
                        //  }
                    }
                    if (!pendants.Contains(i))
                        pendants.Add(i);
                    break;
                }
            }
        }
        //selects an arbitrary *non-tops* vertex and makes it a tops by *adding* arbitrary edges.
        public void makeTop(int k)
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count <= k)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjListArray[i].Count <= k)
                        {
                            if (addEdge(i, j))
                            {
                               
                                Console.WriteLine();
                                Console.WriteLine("Connected " + i + " to " + j);
                                Console.WriteLine();

                            }
                        }
                    }
                    if (!tops.Contains(i))
                        tops.Add(i);
                    break;
                }
            }
        }
        //selects an arbitrary *tops* vertex and makes it a *non* tops by *removing* arbitrary edges.
        public void makeNonTop(int k)
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjListArray[i].Count > k)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjListArray[i].Count > k)
                        {
                            if (removeEdge(i, j))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Removed " + i + " to " + j);
                                Console.WriteLine();
                                //break;
                            }
                        }
                    }
                    if (tops.Contains(i))
                        tops.Remove(i);
                    break;
                }
            }
        }



        public void addEdgesOnProbability(int probability)
        {
            for (int i = 0; i < vertices - 1; i++)
            {
                for (int j = i + 1; j < vertices; j++)
                {
                    //the generated number is *equal or above* the min(1) and *bellow* the max()
                    int chance = randomNr.Next(1, 101);
                    if (chance <= probability)
                    {
                        addEdge(i, j);
                    }

                }
            }
        }

        // Adds an edge to an undirected graph
        public bool addEdge(int src, int dest)
        {
            if (adjListArray[src].Contains(dest) || src == dest)
                return false;
            // Add an edge from src to dest.           
            adjListArray[src].Add(dest);

            // Since graph is undirected, add an edge from dest
            // to src also
            adjListArray[dest].Add(src);
            return true;
        }

        public bool removeEdge(int src, int dest)
        {
            if (adjListArray[src].Contains(dest) && adjListArray[dest].Contains(src))
            {
                adjListArray[src].Remove(dest);
                adjListArray[dest].Remove(src);
                // Console.WriteLine("removed edge" + src + " " + dest);
                return true;
            }
            return false;
        }

        public void connectGraph()
        {
            foreach (int vertice in verticesToConnect)
            {
                addEdge(verticesToConnect[0], vertice);
            }
        }

        public void ReachableVert(int v, bool[] visited, bool foundArbitraryVertice)
        {
            if (!foundArbitraryVertice)
            {
                verticesToConnect.Add(v);
                foundArbitraryVertice = true;
            }

            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write(/*"f "+*/ v + " ");
            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int x in adjListArray[v])
            {
                if (!visited[x])
                    ReachableVert(x, visited, foundArbitraryVertice);
            }
        }



        public void connectedComponents()
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[vertices];
            for (int v = 0; v < vertices; ++v)
            {
                if (!visited[v])
                {
                    // print all reachable vertices
                    // from v
                    ReachableVert(v, visited, false);
                    Console.WriteLine();
                }
            }
        }

        public void updateColorGraphToFile()
        {
            //printGraphInConsole();
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("graph.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                // fileStream.Seek(0, SeekOrigin.End);
                //File.WriteAllText("graph.dot", "");
                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjListArray.Count(); i++)
                {
                    if (tops.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#4040f040\"]");
                    else if (pendants.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#40f04040\"]");
                    else if (isolatedVertices.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#f0404040\"]");
                    else
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjListArray.Count(); i++)
                {
                    for (int j = 0; j < adjListArray[i].Count(); j++)
                    {
                        if (adjListArray[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjListArray[i][j]);
                        }
                    }
                }
                streamWriter.WriteLine("}");

            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }

        public void printGraphInConsole()
        {
            for (int i = 0; i < adjListArray.Count(); i++)
            {
                Console.WriteLine("\nAdjacency list of vertex " + i);
                Console.Write("head");
                for (int j = 0; j < adjListArray[i].Count(); j++)
                {
                    Console.Write(" -> " + adjListArray[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void writeGraphToFile()
        {
            printGraphInConsole();
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("graph.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                // fileStream.Seek(0, SeekOrigin.End);
                //File.WriteAllText("graph.dot", "");
                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjListArray.Count(); i++)
                {
                    streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjListArray.Count(); i++)
                {
                    for (int j = 0; j < adjListArray[i].Count(); j++)
                    {
                        if (adjListArray[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjListArray[i][j]);
                        }
                    }
                }
                streamWriter.WriteLine("}");

            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }

        public bool ValidateSmart(int[] cover, int n, int k)
        {
            if (!ok)
                return true;
           // Console.WriteLine("VERTEX COVER POSSIBILITY:");
            int count = 0;
            for (int i = 0; i < cover.Length; i++)
            {
               // Console.WriteLine(i + " => " + cover[i]);
                if (cover[i] != 0) { count++; }
            }

            bool success = true;
            if ((count <= k)&&( count + getIsolatedVertices().Count+ getPendants().Count >= k)  )
            {
                for (int i = 0; i < cover.Length; i++)
                {
                    for (int j = 0; j < adjListArray[i].Count; j++)
                    {
                        if ((cover[i] == 0) && (cover[adjListArray[i][j]] == 0))
                        {
                            success = false;
                            return false;
                        }
                    }
                }
            }
            else
            {
                success = false;
                return false;
            }
            for (int i = 0; i < cover.Length; i++)
            {
                Console.WriteLine(i + " => " + cover[i]);
            }
            Console.WriteLine("Node COUNT => " + count);
            Console.WriteLine("SUCCESS => " + success);

            if (success == true)
            {
                ok = false;
            }


            return success;
        }


        public bool Validate(bool[] cover, int n, int k)
        {
            if (!ok)
                return true;
           // Console.WriteLine("VERTEX COVER POSSIBILITY:");
            int count = 0;
            for (int i = 0; i < cover.Length; i++)
            {
              //  Console.WriteLine(i + " => " + cover[i]);
                if (cover[i] == true) { count++; }
            }

            bool success = true;
            if (count == k)
            {
                for (int i = 0; i < cover.Length; i++)
                {
                    for (int j = 0; j < adjListArray[i].Count; j++)
                    {
                        if ((cover[i] == false) && (cover[adjListArray[i][j]] == false))
                        {
                            success = false;
                            return false;
                        }
                    }
                }
            }
            else
            {
                success = false;
                return false;
            }
            for (int i = 0; i < cover.Length; i++)
            {
                Console.WriteLine(i + " => " + cover[i]);
            }
            Console.WriteLine("Node COUNT => " + count);
            Console.WriteLine("SUCCESS => " + success);

            if (success == true)
            {
                ok = false;
            }


            return success;
        }

        public int GetVertices() { return vertices; }
        //public bool[] GetVertexCover() { return vertexCover; }
        //public void ResetVertexCover() { vertexCover = null; }

    }


}

