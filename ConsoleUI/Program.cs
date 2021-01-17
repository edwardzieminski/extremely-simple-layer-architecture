using ConsoleUI.EncoderAdapters;
using System;

Console.WriteLine("Give me some text: ");
var textToBeEncoded = Console.ReadLine();

Console.WriteLine("Encoded text: ");
EncoderTextReader encoderTextReader = new EncoderTextReader(new EncoderTextWriter());
encoderTextReader.EncodeText(textToBeEncoded);
Console.WriteLine(encoderTextReader.TextWriter.EncodedText);

Console.ReadKey();