namespace BasicAlgorithms
{
    public class BreadthFirstSearch
    {
        private int v; // Số đỉnh
        private List<int>[] adjacencyList; // Danh sách kề

        public BreadthFirstSearch(int v)
        {
            this.v = v;
            adjacencyList = new List<int>[this.v];
            for (int i = 0; i < this.v; ++i)
                adjacencyList[i] = new List<int>();
        }

        private void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
        }

        private void BreadthFirstSearchHandler(int startVertex)
        {
            // Mảng đánh dấu các đỉnh đã được thăm
            bool[] visited = new bool[v];

            // Hàng đợi để theo dõi các đỉnh cần duyệt
            Queue<int> queue = new Queue<int>();

            // Bắt đầu từ đỉnh startVertex
            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                // Lấy một đỉnh từ hàng đợi và in ra
                startVertex = queue.Dequeue();
                Console.Write(startVertex + " ");

                // Lặp qua tất cả các đỉnh kề của đỉnh vừa được thăm
                foreach (int neighbor in adjacencyList[startVertex])
                {
                    // Nếu đỉnh chưa được thăm, đánh dấu là đã thăm và thêm vào hàng đợi
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        public static void BreadthFirstSearchResult()
        {
            Console.WriteLine("Thuat toan Breadth-First Search");

            BreadthFirstSearch graph = new BreadthFirstSearch(8);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 6);
            graph.AddEdge(4, 7);

            Console.WriteLine("Duyet BFS tu dinh 0:");
            graph.BreadthFirstSearchHandler(0);

            Console.WriteLine();
        }
    }
}
