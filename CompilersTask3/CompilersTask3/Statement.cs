using System.CodeDom;

namespace CompilersTask3
{
    public class Statement
    {
        private Assignment _assignment;
        private IfStatement _ifStatement;
        private WhileStatement _whileStatement;
        private ReturnStatement _returnStatement;
        private CallStatement _callStatement;
        private PrintStatement _printStatement;
        private Block _block;
    }
}