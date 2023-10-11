namespace BasicAlgorithms
{
    // 1.Duyệt Theo Chiều Sâu:
    // DFS duyệt đồ thị theo chiều sâu, tức là khi nó bắt đầu từ một đỉnh và tiếp tục duyệt một nhánh đến khi không còn đỉnh nào nữa,
    // sau đó quay lại và duyệt các nhánh khác.
    //
    // 2.Đỉnh Bắt Đầu:
    // DFS bắt đầu từ một đỉnh bắt đầu và thăm tất cả các đỉnh kề của nó trước khi di chuyển đến các đỉnh kề của các đỉnh đó.
    // 
    // 3.Đệ Quy Hoặc Ngăn Xếp:
    // DFS thường được triển khai bằng đệ quy hoặc sử dụng ngăn xếp để theo dõi các đỉnh cần duyệt.
    public class DepthFirstSearch
    {
        private int v; // Số đỉnh
        private List<int>[] adjacencyList; // Danh sách kề

        public DepthFirstSearch(int v)
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

        private void DepthFirstSearchHandler(int startVertex)
        {
            // Mảng đánh dấu các đỉnh đã được thăm
            bool[] visited = new bool[v];

            // Gọi hàm đệ quy để thực hiện DFS
            DepthFirstSearchUtil(startVertex, visited);
        }

        private void DepthFirstSearchUtil(int v, bool[] visited)
        {
            // Đánh dấu đỉnh hiện tại là đã thăm và in ra
            visited[v] = true;
            Console.Write(v + " ");

            // Duyệt qua tất cả các đỉnh kề của đỉnh hiện tại
            foreach (int neighbor in adjacencyList[v])
            {
                // Nếu đỉnh chưa được thăm, gọi đệ quy để thăm đỉnh đó
                if (!visited[neighbor])
                    DepthFirstSearchUtil(neighbor, visited);
            }
        }

        public static void DepthFirstSearchResult()
        {
            Console.WriteLine("Thuat toan Depth-First Search");

            DepthFirstSearch graph = new DepthFirstSearch(8);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 6);
            graph.AddEdge(4, 7);

            Console.WriteLine("Duyet DFS tu dinh 0:");
            graph.DepthFirstSearchHandler(0);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
