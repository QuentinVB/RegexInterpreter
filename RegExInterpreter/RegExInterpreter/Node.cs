using System;
using System.Collections.Generic;
using System.Text;

namespace RegExInterpreter
{
    public class Node
    {
        readonly char _symbol;
        readonly Node _left;
        readonly Node _right;

        public Node( char symbol)
            :this(symbol, null, null)
        {

        }
        public Node(char symbol, Node left)
            : this(symbol, left, null)
        {

        }
        public Node(char symbol, Node left, Node right)
        {
            _symbol = symbol;
            _left = left;
            _right = right;
        }

        public char Symbol => _symbol;

        public Node Left => _left;

        public Node Right => _right;
        public override string ToString()
        {
            if (char.IsLetterOrDigit(Symbol)) return _symbol.ToString();
            if (Symbol == '*') return string.Format("(* {0})", Left);
            return string.Format("({0} {1} {2})", Symbol, Left, Right);
        }
    }
}
