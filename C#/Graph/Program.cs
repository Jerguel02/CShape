namespace Graph;
class Program
{
    class Graph
    {
        int vertical;
        int[,] adjMat;
        public Graph(int n)
        {
            vertical = n;;
            adjMat = new int[n,n];
        }
        public void insertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }
        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }
        public bool existsEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }
        public int vertexCount()
        {
            return vertical;
        }
        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertical; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public void edge()
        {
            Console.WriteLine("Edge: ");
            for (int i = 0; i < vertical; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        Console.WriteLine(i + "--"+ j);
                    }
                    
                }
               
            }
        }
        public int outdegree(int v)
        {
            int count = 0;
            for (int j = 0; j <vertical; j++)
            {
                if (adjMat[v, j] != 0)
                {
                    count++;
                }
            
            }
            return count;
        }
        public int indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertical; i++)
            {
                for(int j = 0; j < vertical; j++)
                if (adjMat[i,j] != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public void display()
        {
            for (int i = 0; i < vertical; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    Console.Write(adjMat[i,j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        Graph G = new Graph(4);
        Console.WriteLine("Graph Adjancency Matrix: ");
        G.display();
        Console.WriteLine("Vertices: " + G.vertexCount());
        Console.WriteLine("Edges Count: " + G.edgeCount());
        G.insertEdge(0,1,26);
        G.insertEdge(0,2,16);
        G.insertEdge(1,0,26);
        G.insertEdge(1,2,12);
        G.insertEdge(2,0,16);
        G.insertEdge(2,1,12);
        G.insertEdge(2,3,8);
        G.insertEdge(3,2,8);
        Console.WriteLine("Graph Adjacency Matrix: ");
        G.display();
        Console.WriteLine("Vertices: " + G.vertexCount());
        Console.WriteLine("Edges Count: " + G.edgeCount());
        G.edge();

        
    }
}
