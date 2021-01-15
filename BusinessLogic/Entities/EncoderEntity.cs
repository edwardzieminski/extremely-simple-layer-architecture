using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Entities
{
    internal sealed class EncoderEntity
    {
        internal string Encode(string text)
        {
            var charList = text
                .ToCharArray()
                .ToList();

            var encodedCharsList = new List<string>();

            charList.ForEach(c => { encodedCharsList.Add($"({ c })"); });

            return string.Join("",encodedCharsList);
        }
    }
}
