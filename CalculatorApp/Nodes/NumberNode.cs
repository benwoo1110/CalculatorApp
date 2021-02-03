using System;
using System.Globalization;
using CalculatorApp.Enums;

namespace CalculatorApp.Nodes
{
    public class NumberNode : Node
    {
        public double Number { get; set; }

        public NumberNode(double number) : base(NodeType.Number)
        {
            Number = number;
        }

        public NumberNode(string number) : base(NodeType.Number)
        {
            if (number.EndsWith('.'))
            {
                number.Remove(number.Length - 1);
            }

            Number = Convert.ToDouble(number, CultureInfo.GetCultureInfo("en-US"));
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}