using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorApp.Enums;
using CalculatorApp.Nodes;

namespace CalculatorApp
{
    public class ExpressionBuilder
    {
        private List<Node> nodes;

        public ExpressionBuilder(List<Node> nodes)
        {
            this.nodes = nodes;
        }

        public ExpressionBuilder(string expression)
        {
            nodes = new List<Node>();
            
            var buffer = new StringBuilder();

            if (expression[0].Equals('-'))
            {
                buffer.Append('-');
                expression = expression.Remove(0, 1);
            }
            
            if (expression[0].Equals('+'))
            {
                expression = expression.Remove(0, 1);
            }
            
            foreach (var c in expression)
            {
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }
                
                if (char.IsDigit(c) || c.Equals('.'))
                {
                    buffer.Append(c);
                }
                else if (OperatorNode.IsValidOperator(c.ToString()))
                {
                    if (buffer.Length != 0)
                    {
                        nodes.Add(new NumberNode(buffer.ToString()));
                    }

                    nodes.Add(new OperatorNode(c.ToString()));
                    buffer.Clear();
                }
                else
                {
                    throw new ArgumentException("Unknown character: " + c);
                }
            }

            if (buffer.Length > 0)
            {
                nodes.Add(new NumberNode(buffer.ToString()));
            }
        }

        public double Calculate()
        {
            Console.WriteLine("Expression: " + ToString());
            ResolveBrackets();
            Console.WriteLine("Brackets: " + ToString());
            ResolveOperator(new[] {OperatorType.Divide, OperatorType.Multiply});
            Console.WriteLine("/ and *: " + ToString());
            ResolveOperator(new[] {OperatorType.Add, OperatorType.Subtract});
            Console.WriteLine("+ and -: " + ToString());


            return ((NumberNode) nodes[0]).Number;
        }

        private void ResolveOperator(OperatorType[] typesToResolve)
        {
            if (nodes.Count <= 1)
            {
                return;
            }
            
            var resolveNodes = new List<Node>();
            
            for (var index=0; index<=nodes.Count-2; index+=2)
            {
                var operatorNode = (OperatorNode) nodes[index + 1];
                if (typesToResolve.Contains(operatorNode.Operator))
                {
                    nodes[index + 2] = CalculateNumberPair((NumberNode) nodes[index], operatorNode, (NumberNode) nodes[index + 2]);
                }
                else
                {
                    resolveNodes.Add(nodes[index]);
                    resolveNodes.Add(nodes[index+1]);
                }
            }

            if (resolveNodes.Count == 0 || resolveNodes.Last() is OperatorNode)
            {
                resolveNodes.Add(nodes.Last());
            }

            nodes = resolveNodes;
        }

        private NumberNode CalculateNumberPair(NumberNode num1, OperatorNode opt, NumberNode num2)
        {
            double result = -1;
            switch (opt.Operator)
            {
                case OperatorType.Add:
                    result = num1.Number + num2.Number;
                    break;
                case OperatorType.Subtract:
                    result = num1.Number - num2.Number;
                    break;
                case OperatorType.Divide:
                    result = num1.Number / num2.Number;
                    break;
                case OperatorType.Multiply:
                    result = num1.Number * num2.Number;
                    break;
            }
            return new NumberNode(result);
        }
        
        private void ResolveBrackets()
        {
            var resolveNodes = new List<Node>();
            
            var openCount = 0;
            var openIndex = -1;
            var counter = -1;
            
            foreach (var node in nodes)
            {
                counter++;
                
                if (!(node is OperatorNode operatorNode))
                {
                    if (openCount == 0)
                    {
                        resolveNodes.Add(node);
                    }

                    continue;
                }

                switch (operatorNode.Operator)
                {
                    case OperatorType.OpenBracket:
                    {
                        if (openCount == 0)
                        {
                            openIndex = counter+1;
                        }
                        openCount++;
                        break;
                    }
                    
                    case OperatorType.CloseBracket:
                    {
                        openCount--;
                    
                        if (openCount == 0 && openIndex != -1)
                        {
                            var expression =
                                new ExpressionBuilder(nodes.GetRange(openIndex, counter - openIndex)); 
                            resolveNodes.Add(new NumberNode(expression.Calculate()));
                        }

                        break;
                    }
                    
                    default:
                    {
                        if (openCount == 0)
                        {
                            resolveNodes.Add(node);
                        }

                        break;
                    }
                }
            }

            nodes = resolveNodes;
        }

        public override string ToString()
        {
            var buffer = new StringBuilder();
            nodes.ForEach(node => buffer.Append(node).Append(' '));
            return buffer.ToString();
        }
    }
}