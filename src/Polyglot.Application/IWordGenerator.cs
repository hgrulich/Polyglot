using Polyglot.Application.Models;
using System;
using System.Linq;

namespace Polyglot.Application
{
    public interface IWordGenerator
    {
        Word CreateWord(string word, string czechMeaning);
        Word CreateWord(string word, string plural, string czechMeaning);
    }
}
