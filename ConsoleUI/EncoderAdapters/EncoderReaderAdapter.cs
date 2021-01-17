using BusinessLogic.InputOutput;

namespace ConsoleUI.EncoderAdapters
{
    public class EncoderTextReader : TextReaderBase
    {
        public EncoderTextReader(ITextWriter valueWriter) : base(valueWriter)
        {

        }
    }
}
