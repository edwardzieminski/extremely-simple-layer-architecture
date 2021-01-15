using BusinessLogic.InputOutput;

namespace ConsoleUI.EncoderAdapters
{
    public class EncoderReaderAdapter : TextReaderBase
    {
        public EncoderReaderAdapter(ITextWriter valueWriter) : base(valueWriter)
        {

        }
    }
}
