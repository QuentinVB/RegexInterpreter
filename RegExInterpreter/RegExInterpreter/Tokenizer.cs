using System;
using System.Text;

namespace RegExInterpreter
{
    public class Tokenizer
    {
        readonly string _text;
        int _headPos;
        TokenType _current;
        char _currentCaractere;
        readonly StringBuilder _buffer;




        public Tokenizer(string text)
        {
            _buffer = new StringBuilder();
            _text = text;
            Next();
        }

        bool IsEnd => _headPos >= _text.Length;

        char Head => _text[_headPos];

        char Forward() => _text[_headPos++];

        TokenType Current => _current;

        public int CaractereValue => _currentCaractere;

        private TokenType Next()
        {
            if (IsEnd) return _current = TokenType.EOS;
            char c = Forward();
            switch (c)
            {
                case '?': return _current = TokenType.ZeroOROne;
                case '+': return _current = TokenType.OneOrMany;
                case '*': return _current = TokenType.ZeroOrMany;
                case '|': return _current = TokenType.Or;
                case '(': return _current = TokenType.OpenBracket;
                case ')': return _current = TokenType.CloseBracket;
                default:
                    if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) return TokenType.Caractere;
                    else return TokenType.Error;
            }
        }
    }
}
