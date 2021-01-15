using ConsoleUI.EncoderAdapters;
using System;

Console.WriteLine("Give me some text: ");
var textToBeEncoded = Console.ReadLine();

Console.WriteLine("Encoded text: ");
EncoderReaderAdapter encoderReaderAdapter = new EncoderReaderAdapter(new EncoderWriterAdapter());
encoderReaderAdapter.EncodeText(textToBeEncoded);
Console.WriteLine(encoderReaderAdapter.TextWriter.EncodedText);

Console.ReadKey();