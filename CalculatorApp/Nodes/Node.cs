using CalculatorApp.Enums;

namespace CalculatorApp.Nodes
{
    public abstract class Node
    {
        public NodeType Type { get; }

        protected Node(NodeType type)
        {
            Type = type;
        }
    }
}