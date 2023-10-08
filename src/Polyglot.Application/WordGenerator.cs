using Polyglot.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyglot.Application
{
    public class WordGenerator : IWordGenerator
    {
        public Word CreateWord(string word, string plural, string czechMeaning)
            => new Word($"{word} {plural}", czechMeaning, word);

        public Word CreateWord(string word, string czechMeaning)
            => new Word(word, czechMeaning, word);
    }
}
