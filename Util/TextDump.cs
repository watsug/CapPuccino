using System.IO;

namespace CapPuccino.Util
{
    public class TextDump
    {
        private TextWriter _wr;

        public TextDump(TextWriter wr)
        {
            _wr = wr;
        }

        public void WriteLine(int ident, string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                _wr.WriteLine();
            }
            else
            {
                _wr.WriteLine(GenerateIdent(ident) + line);
            }
        }

        private string GenerateIdent(int ident)
        {
            return new string(' ', ident * 4);
        }
    }
}