using System.Collections.Generic;
using System.Linq;

public class BFS
{

    private Queue<Node> _nodesToVisit;
    private HashSet<Node> _visited;
    private Dictionary<Node, Node> _previous;

    public List<Node> FindPath(Node start, Node target)
    {
        Clear();

        List<Node> _pathToTarget = new List<Node>();

        Node next;
        Node previous;

        _nodesToVisit.Enqueue(start);

        while (true)
        {
            if (!_nodesToVisit.TryDequeue(out next))
                return null;

            if (next.Position == target.Position)
                break;

            if (_visited.Contains(next))
                continue;

            _visited.Add(next);

            foreach(Node node in next.Neighbours)
            {
                if (!_previous.ContainsKey(node))
                {
                    _nodesToVisit.Enqueue(node);
                    _previous.Add(node, next);
                }
            }
        }

        _pathToTarget.Add(next);

        while (true)
        {
            if (next.Position == start.Position)
                break;

            previous = _previous[next];
            _pathToTarget.Add(previous);
            next = previous;
        }


        return Enumerable.Reverse(_pathToTarget).ToList();
    }

    private void Clear()
    {
        _nodesToVisit = new Queue<Node>();
        _visited = new HashSet<Node>();
        _previous = new Dictionary<Node, Node>();
    }

}


