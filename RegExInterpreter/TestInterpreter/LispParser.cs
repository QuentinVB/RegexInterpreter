using RegExInterpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterpreter
{
    class LispParser
    {
        readonly Cursor _cursor;
        public LispParser(string regex)
        {
            _cursor = new Cursor(regex);
        }
        public Node Parse()
        {
            Node exp = ParseRegex();
            if (exp == null) return null;

            if (_cursor.Current == 0) return exp;
            return null;
        }
        Node ParseRegex()
        {
            Node root = null;

            while (true)
            {
                Node exp = ParseConcatExp();
                if (exp == null) return exp;
                if (root == null) root = exp;
                else root = new Node('|', root, exp);
                if (_cursor.Current == '|') _cursor.Next();
                else return root;
            }
            
        }
        Node ParseConcatExp()
        {
            Node root = null;
            do
            {
                Node exp = ParseStarExp();
                if (root == null) root = exp;
                else root = new Node('+', root, exp);
                if (exp == null) return null;
            } while (_cursor.Current == '(' || char.IsLetterOrDigit(_cursor.Current));
            return root;
        }
        Node ParseStarExp()
        {
            Node exp = ParseStarizableExp();
            if (exp == null) return null;
            if(_cursor.Current == '*')
            {
                exp = new Node('*', exp, null);
                _cursor.Next();
            }
            return exp;
        }
        Node ParseStarizableExp()
        {
            if (_cursor.Current == '(') return ParseParenthesisExp();
            if (char.IsLetterOrDigit(_cursor.Current)) return ParseCharExp();
            else return null;
        }
        Node ParseParenthesisExp()
        {
            //elimine les parenthèse, le noeud "parenthèse" est inutile
            if (_cursor.Current != '(') return null;
            else _cursor.Next();
            Node exp = ParseRegex();
            if (_cursor.Current != ')') return null;
            _cursor.Next();
            return exp;
        }
        Node ParseCharExp()
        {
            if (!char.IsLetterOrDigit(_cursor.Current)) return null;
            Node node = new Node(_cursor.Current);
            _cursor.Next();
            return node;

        }
    }
    class Cursor
    {
        readonly string _s;
        int _idx;
        public Cursor(string s)
        {
            _s = s ?? string.Empty;
            _idx = 0;
        }
        public char Current
        {
            get { return Lookahead(0); }
        }
        public void Next()
        {
            _idx++;
        }
        public char Lookahead(int n)
        {
            if (_idx + n >= _s.Length) return (char)0;
            return _s[_idx + n];
        }
    }
}
