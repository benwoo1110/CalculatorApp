namespace CalculatorApp
{
    public abstract class Node
    {
        public NodeType Type { get; set; }

        protected Node(NodeType type)
        {
            Type = type;
        }
    }
}