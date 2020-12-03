using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class OperatorNode : Node
    {
        private static readonly Dictionary<string, OperatorType> OperatorMap = new Dictionary<string, OperatorType>
        {
            {"+", OperatorType.Add},
            {"-", OperatorType.Subtract},
            {"x", OperatorType.Multiply},
            {"÷", OperatorType.Divide},
            {"(", OperatorType.OpenBracket},
            {")", OperatorType.CloseBracket},
        }; 
        
        private static readonly Dictionary<OperatorType, string> StringMap = new Dictionary<OperatorType, string>
        {
            {OperatorType.Add, "+"},
            {OperatorType.Subtract, "-"},
            {OperatorType.Multiply, "x"},
            {OperatorType.Divide, "÷"},
            {OperatorType.OpenBracket, "("},
            {OperatorType.CloseBracket, ")"},
        }; 
        
        public OperatorType Operator { get; set; }

        public OperatorNode(string opt) : base(NodeType.Operator)
        {
            if (!OperatorMap.TryGetValue(opt, out var operatorType))
            {
                throw new ArgumentException();   
            }
            Operator = operatorType;
        }

        public static bool IsValidOperator(string opt)
        {
            return OperatorMap.TryGetValue(opt, out _);
        }

        public override string ToString()
        {
            return StringMap.GetValueOrDefault(Operator);
        }
    }
}