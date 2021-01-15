using BusinessLogic.Entities;

namespace BusinessLogic.InputOutput
{
    public abstract class TextReaderBase
    {
        private readonly EncoderEntity _encoderEntity = new EncoderEntity();

        public TextReaderBase(ITextWriter textWriter)
        {
            TextWriter = textWriter;
        }

        public ITextWriter TextWriter { get; private set; }

        public void EncodeText(string text)
        {
            TextWriter.EncodedText = _encoderEntity.Encode(text);
        }
    }
}
