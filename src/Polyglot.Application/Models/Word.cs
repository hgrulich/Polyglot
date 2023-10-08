using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyglot.Application.Models
{
    public record Word(string ForeignWord, string CzechMeaning, string TranslatorSearchString);
}
