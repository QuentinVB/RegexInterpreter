using System;
using System.Collections.Generic;
using System.Text;

namespace RegExInterpreter
{
    enum TokenType
    {
        Error = -1,
        EOS = 0,
        Caractere,
        ZeroOROne,
        OneOrMany,
        ZeroOrMany,
        Or,
        OpenBracket,
        CloseBracket,
    }
}
