namespace Polyglot.Application
{
    public class VocabularyService
    {
        readonly HttpClient _client;
        public VocabularyService(HttpClient client)
        {
            _client = client;
        }

        public Task InitializeAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }
    }
}