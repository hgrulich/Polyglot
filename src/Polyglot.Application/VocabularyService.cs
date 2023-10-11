using Polyglot.Application.Models;

namespace Polyglot.Application
{
    public class VocabularyService : IVocabularyService
    {
        public Lesson[] AvailableLessons { get; private set; }
        readonly HttpClient _client;

        public VocabularyService(HttpClient client)
        {
            _client = client;
        }

        public Task InitializeAsync(CancellationToken token)
        {
            AvailableLessons = new Lesson[]
            {
                new Lesson("a", new Word[] { new Word("x", "y", "z") }),
                new Lesson("b", new Word[] { new Word("k", "l", "m") })
            };
            return Task.CompletedTask;
        }
    }
}